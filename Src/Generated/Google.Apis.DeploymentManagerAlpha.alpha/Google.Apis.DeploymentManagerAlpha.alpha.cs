// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.DeploymentManagerAlpha.alpha
{
    /// <summary>The DeploymentManagerAlpha Service.</summary>
    public class DeploymentManagerAlphaService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DeploymentManagerAlphaService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DeploymentManagerAlphaService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            CompositeTypes = new CompositeTypesResource(this);
            Deployments = new DeploymentsResource(this);
            Manifests = new ManifestsResource(this);
            Operations = new OperationsResource(this);
            Resources = new ResourcesResource(this);
            TypeProviders = new TypeProvidersResource(this);
            Types = new TypesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "deploymentmanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://www.googleapis.com/deploymentmanager/alpha/projects/";
        #else
            "https://www.googleapis.com/deploymentmanager/alpha/projects/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "deploymentmanager/alpha/projects/";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://www.googleapis.com/batch/deploymentmanager/alpha";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/deploymentmanager/alpha";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Cloud Deployment Manager Alpha API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>View and manage your Google Cloud Platform management resources and deployment status
            /// information</summary>
            public static string NdevCloudman = "https://www.googleapis.com/auth/ndev.cloudman";

            /// <summary>View your Google Cloud Platform management resources and deployment status
            /// information</summary>
            public static string NdevCloudmanReadonly = "https://www.googleapis.com/auth/ndev.cloudman.readonly";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Cloud Deployment Manager Alpha API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>View and manage your Google Cloud Platform management resources and deployment status
            /// information</summary>
            public const string NdevCloudman = "https://www.googleapis.com/auth/ndev.cloudman";

            /// <summary>View your Google Cloud Platform management resources and deployment status
            /// information</summary>
            public const string NdevCloudmanReadonly = "https://www.googleapis.com/auth/ndev.cloudman.readonly";

        }



        /// <summary>Gets the CompositeTypes resource.</summary>
        public virtual CompositeTypesResource CompositeTypes { get; }

        /// <summary>Gets the Deployments resource.</summary>
        public virtual DeploymentsResource Deployments { get; }

        /// <summary>Gets the Manifests resource.</summary>
        public virtual ManifestsResource Manifests { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Resources resource.</summary>
        public virtual ResourcesResource Resources { get; }

        /// <summary>Gets the TypeProviders resource.</summary>
        public virtual TypeProvidersResource TypeProviders { get; }

        /// <summary>Gets the Types resource.</summary>
        public virtual TypesResource Types { get; }
    }

    /// <summary>A base abstract class for DeploymentManagerAlpha requests.</summary>
    public abstract class DeploymentManagerAlphaBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DeploymentManagerAlphaBaseServiceRequest instance.</summary>
        protected DeploymentManagerAlphaBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>An opaque string that represents a user for quota purposes. Must not exceed 40
        /// characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes DeploymentManagerAlpha parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
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
            RequestParameters.Add("userIp", new Google.Apis.Discovery.Parameter
            {
                Name = "userIp",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "compositeTypes" collection of methods.</summary>
    public class CompositeTypesResource
    {
        private const string Resource = "compositeTypes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CompositeTypesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Deletes a composite type.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="compositeType">The name of the
        /// type for this request.</param>
        public virtual DeleteRequest Delete(string project, string compositeType)
        {
            return new DeleteRequest(service, project, compositeType);
        }

        /// <summary>Deletes a composite type.</summary>
        public class DeleteRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string compositeType) : base(service)
            {
                Project = project;
                CompositeType = compositeType;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the type for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("compositeType", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CompositeType { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/compositeTypes/{compositeType}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("compositeType", new Google.Apis.Discovery.Parameter
                {
                    Name = "compositeType",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9_.]{0,61}[a-z0-9])?",
                });
            }

        }

        /// <summary>Gets information about a specific composite type.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="compositeType">The name of the
        /// composite type for this request.</param>
        public virtual GetRequest Get(string project, string compositeType)
        {
            return new GetRequest(service, project, compositeType);
        }

        /// <summary>Gets information about a specific composite type.</summary>
        public class GetRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.CompositeType>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string compositeType) : base(service)
            {
                Project = project;
                CompositeType = compositeType;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the composite type for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("compositeType", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CompositeType { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/compositeTypes/{compositeType}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("compositeType", new Google.Apis.Discovery.Parameter
                {
                    Name = "compositeType",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9_.]{0,61}[a-z0-9])?",
                });
            }

        }

        /// <summary>Creates a composite type.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        public virtual InsertRequest Insert(Google.Apis.DeploymentManagerAlpha.alpha.Data.CompositeType body, string project)
        {
            return new InsertRequest(service, body, project);
        }

        /// <summary>Creates a composite type.</summary>
        public class InsertRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.CompositeType body, string project) : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.CompositeType Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/compositeTypes";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
            }

        }

        /// <summary>Lists all composite types for Deployment Manager.</summary>
        /// <param name="project">The project ID for this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(service, project);
        }

        /// <summary>Lists all composite types for Deployment Manager.</summary>
        public class ListRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.CompositeTypesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>A filter expression that filters resources listed in the response. The expression must specify
            /// the field name, a comparison operator, and the value that you want to use for filtering. The value must
            /// be a string, a number, or a boolean. The comparison operator must be either `=`, `!=`, `>`, or `<`.
            ///
            /// For example, if you are filtering Compute Engine instances, you can exclude instances named `example-
            /// instance` by specifying `name != example-instance`.
            ///
            /// You can also filter nested fields. For example, you could specify `scheduling.automaticRestart = false`
            /// to include instances only if they are not scheduled for automatic restarts. You can use filtering on
            /// nested fields to filter based on resource labels.
            ///
            /// To filter on multiple expressions, provide each separate expression within parentheses. For example: ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake") ``` By default, each expression is
            /// an `AND` expression. However, you can include `AND` and `OR` expressions explicitly. For example: ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND (scheduling.automaticRestart =
            /// true) ```</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results per page that should be returned. If the number of available
            /// results is larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get
            /// the next page of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive.
            /// (Default: `500`)</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Sorts list results by a certain order. By default, results are returned in alphanumerical order
            /// based on the resource name.
            ///
            /// You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first.
            ///
            /// Currently, only sorting by `name` or `creationTimestamp desc` is supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous
            /// list request to get the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Opt-in for partial success behavior which provides partial results in case of failure. The
            /// default value is false and the logic is the same as today.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/compositeTypes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "returnPartialSuccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Patches a composite type.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="compositeType">The name of the
        /// composite type for this request.</param>
        public virtual PatchRequest Patch(Google.Apis.DeploymentManagerAlpha.alpha.Data.CompositeType body, string project, string compositeType)
        {
            return new PatchRequest(service, body, project, compositeType);
        }

        /// <summary>Patches a composite type.</summary>
        public class PatchRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.CompositeType body, string project, string compositeType) : base(service)
            {
                Project = project;
                CompositeType = compositeType;
                Body = body;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the composite type for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("compositeType", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CompositeType { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.CompositeType Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/compositeTypes/{compositeType}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("compositeType", new Google.Apis.Discovery.Parameter
                {
                    Name = "compositeType",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9_.]{0,61}[a-z0-9])?",
                });
            }

        }

        /// <summary>Updates a composite type.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="compositeType">The name of the
        /// composite type for this request.</param>
        public virtual UpdateRequest Update(Google.Apis.DeploymentManagerAlpha.alpha.Data.CompositeType body, string project, string compositeType)
        {
            return new UpdateRequest(service, body, project, compositeType);
        }

        /// <summary>Updates a composite type.</summary>
        public class UpdateRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.CompositeType body, string project, string compositeType) : base(service)
            {
                Project = project;
                CompositeType = compositeType;
                Body = body;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the composite type for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("compositeType", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CompositeType { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.CompositeType Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/compositeTypes/{compositeType}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("compositeType", new Google.Apis.Discovery.Parameter
                {
                    Name = "compositeType",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9_.]{0,61}[a-z0-9])?",
                });
            }

        }
    }

    /// <summary>The "deployments" collection of methods.</summary>
    public class DeploymentsResource
    {
        private const string Resource = "deployments";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DeploymentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Cancels and removes the preview currently associated with the deployment.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the
        /// deployment for this request.</param>
        public virtual CancelPreviewRequest CancelPreview(Google.Apis.DeploymentManagerAlpha.alpha.Data.DeploymentsCancelPreviewRequest body, string project, string deployment)
        {
            return new CancelPreviewRequest(service, body, project, deployment);
        }

        /// <summary>Cancels and removes the preview currently associated with the deployment.</summary>
        public class CancelPreviewRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new CancelPreview request.</summary>
            public CancelPreviewRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.DeploymentsCancelPreviewRequest body, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Body = body;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.DeploymentsCancelPreviewRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancelPreview";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{deployment}/cancelPreview";

            /// <summary>Initializes CancelPreview parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
            }

        }

        /// <summary>Deletes a deployment and all of the resources in the deployment.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the
        /// deployment for this request.</param>
        public virtual DeleteRequest Delete(string project, string deployment)
        {
            return new DeleteRequest(service, project, deployment);
        }

        /// <summary>Deletes a deployment and all of the resources in the deployment.</summary>
        public class DeleteRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deletePolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DeletePolicyEnum> DeletePolicy { get; set; }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            public enum DeletePolicyEnum
            {
                [Google.Apis.Util.StringValueAttribute("ABANDON")]
                ABANDON,
                [Google.Apis.Util.StringValueAttribute("DELETE")]
                DELETE,
            }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{deployment}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deletePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "deletePolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "DELETE",
                    Pattern = null,
                });
            }

        }

        /// <summary>Gets information about a specific deployment.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the
        /// deployment for this request.</param>
        public virtual GetRequest Get(string project, string deployment)
        {
            return new GetRequest(service, project, deployment);
        }

        /// <summary>Gets information about a specific deployment.</summary>
        public class GetRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Deployment>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{deployment}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
            }

        }

        /// <summary>Gets the access control policy for a resource. May be empty if no such policy or resource
        /// exists.</summary>
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name or id of the resource
        /// for this request.</param>
        public virtual GetIamPolicyRequest GetIamPolicy(string project, string resource)
        {
            return new GetIamPolicyRequest(service, project, resource);
        }

        /// <summary>Gets the access control policy for a resource. May be empty if no such policy or resource
        /// exists.</summary>
        public class GetIamPolicyRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string project, string resource) : base(service)
            {
                Project = project;
                Resource = resource;
                InitParameters();
            }


            /// <summary>Project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Name or id of the resource for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Requested IAM Policy version.</summary>
            [Google.Apis.Util.RequestParameterAttribute("optionsRequestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{resource}/getIamPolicy";

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z0-9](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9_]{0,61}[a-z0-9])?|[1-9][0-9]{0,19}",
                });
                RequestParameters.Add("optionsRequestedPolicyVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "optionsRequestedPolicyVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Creates a deployment and all of the resources described by the deployment manifest.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        public virtual InsertRequest Insert(Google.Apis.DeploymentManagerAlpha.alpha.Data.Deployment body, string project)
        {
            return new InsertRequest(service, body, project);
        }

        /// <summary>Creates a deployment and all of the resources described by the deployment manifest.</summary>
        public class InsertRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.Deployment body, string project) : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("createPolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CreatePolicyEnum> CreatePolicy { get; set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            public enum CreatePolicyEnum
            {
                [Google.Apis.Util.StringValueAttribute("ACQUIRE")]
                ACQUIRE,
                [Google.Apis.Util.StringValueAttribute("CREATE")]
                CREATE,
                [Google.Apis.Util.StringValueAttribute("CREATE_OR_ACQUIRE")]
                CREATEORACQUIRE,
            }

            /// <summary>If set to true, creates a deployment and creates "shell" resources but does not actually
            /// instantiate these resources. This allows you to preview what your deployment looks like. After
            /// previewing a deployment, you can deploy your resources by making a request with the `update()` method or
            /// you can use the `cancelPreview()` method to cancel the preview altogether. Note that the deployment will
            /// still exist after you cancel the preview and you must separately delete this deployment if you want to
            /// remove it.</summary>
            [Google.Apis.Util.RequestParameterAttribute("preview", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Preview { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.Deployment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("createPolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "createPolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "CREATE_OR_ACQUIRE",
                    Pattern = null,
                });
                RequestParameters.Add("preview", new Google.Apis.Discovery.Parameter
                {
                    Name = "preview",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists all deployments for a given project.</summary>
        /// <param name="project">The project ID for this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(service, project);
        }

        /// <summary>Lists all deployments for a given project.</summary>
        public class ListRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.DeploymentsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>A filter expression that filters resources listed in the response. The expression must specify
            /// the field name, a comparison operator, and the value that you want to use for filtering. The value must
            /// be a string, a number, or a boolean. The comparison operator must be either `=`, `!=`, `>`, or `<`.
            ///
            /// For example, if you are filtering Compute Engine instances, you can exclude instances named `example-
            /// instance` by specifying `name != example-instance`.
            ///
            /// You can also filter nested fields. For example, you could specify `scheduling.automaticRestart = false`
            /// to include instances only if they are not scheduled for automatic restarts. You can use filtering on
            /// nested fields to filter based on resource labels.
            ///
            /// To filter on multiple expressions, provide each separate expression within parentheses. For example: ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake") ``` By default, each expression is
            /// an `AND` expression. However, you can include `AND` and `OR` expressions explicitly. For example: ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND (scheduling.automaticRestart =
            /// true) ```</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results per page that should be returned. If the number of available
            /// results is larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get
            /// the next page of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive.
            /// (Default: `500`)</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Sorts list results by a certain order. By default, results are returned in alphanumerical order
            /// based on the resource name.
            ///
            /// You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first.
            ///
            /// Currently, only sorting by `name` or `creationTimestamp desc` is supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous
            /// list request to get the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Opt-in for partial success behavior which provides partial results in case of failure. The
            /// default value is false and the logic is the same as today.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "returnPartialSuccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Patches a deployment and all of the resources described by the deployment manifest.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the
        /// deployment for this request.</param>
        public virtual PatchRequest Patch(Google.Apis.DeploymentManagerAlpha.alpha.Data.Deployment body, string project, string deployment)
        {
            return new PatchRequest(service, body, project, deployment);
        }

        /// <summary>Patches a deployment and all of the resources described by the deployment manifest.</summary>
        public class PatchRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.Deployment body, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Body = body;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("createPolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CreatePolicyEnum> CreatePolicy { get; set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            public enum CreatePolicyEnum
            {
                [Google.Apis.Util.StringValueAttribute("ACQUIRE")]
                ACQUIRE,
                [Google.Apis.Util.StringValueAttribute("CREATE")]
                CREATE,
                [Google.Apis.Util.StringValueAttribute("CREATE_OR_ACQUIRE")]
                CREATEORACQUIRE,
            }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deletePolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DeletePolicyEnum> DeletePolicy { get; set; }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            public enum DeletePolicyEnum
            {
                [Google.Apis.Util.StringValueAttribute("ABANDON")]
                ABANDON,
                [Google.Apis.Util.StringValueAttribute("DELETE")]
                DELETE,
            }

            /// <summary>If set to true, updates the deployment and creates and updates the "shell" resources but does
            /// not actually alter or instantiate these resources. This allows you to preview what your deployment will
            /// look like. You can use this intent to preview how an update would affect your deployment. You must
            /// provide a `target.config` with a configuration if this is set to true. After previewing a deployment,
            /// you can deploy your resources by making a request with the `update()` or you can `cancelPreview()` to
            /// remove the preview altogether. Note that the deployment will still exist after you cancel the preview
            /// and you must separately delete this deployment if you want to remove it.</summary>
            [Google.Apis.Util.RequestParameterAttribute("preview", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Preview { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.Deployment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{deployment}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("createPolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "createPolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "CREATE_OR_ACQUIRE",
                    Pattern = null,
                });
                RequestParameters.Add("deletePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "deletePolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "DELETE",
                    Pattern = null,
                });
                RequestParameters.Add("preview", new Google.Apis.Discovery.Parameter
                {
                    Name = "preview",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }

        }

        /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name or id of the resource
        /// for this request.</param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DeploymentManagerAlpha.alpha.Data.GlobalSetPolicyRequest body, string project, string resource)
        {
            return new SetIamPolicyRequest(service, body, project, resource);
        }

        /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy.</summary>
        public class SetIamPolicyRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.GlobalSetPolicyRequest body, string project, string resource) : base(service)
            {
                Project = project;
                Resource = resource;
                Body = body;
                InitParameters();
            }


            /// <summary>Project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Name or id of the resource for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.GlobalSetPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{resource}/setIamPolicy";

            /// <summary>Initializes SetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z0-9](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9_]{0,61}[a-z0-9])?|[1-9][0-9]{0,19}",
                });
            }

        }

        /// <summary>Stops an ongoing operation. This does not roll back any work that has already been completed, but
        /// prevents any new work from being started.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the
        /// deployment for this request.</param>
        public virtual StopRequest Stop(Google.Apis.DeploymentManagerAlpha.alpha.Data.DeploymentsStopRequest body, string project, string deployment)
        {
            return new StopRequest(service, body, project, deployment);
        }

        /// <summary>Stops an ongoing operation. This does not roll back any work that has already been completed, but
        /// prevents any new work from being started.</summary>
        public class StopRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Stop request.</summary>
            public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.DeploymentsStopRequest body, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Body = body;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.DeploymentsStopRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "stop";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{deployment}/stop";

            /// <summary>Initializes Stop parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
            }

        }

        /// <summary>Returns permissions that a caller has on the specified resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name or id of the resource
        /// for this request.</param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DeploymentManagerAlpha.alpha.Data.TestPermissionsRequest body, string project, string resource)
        {
            return new TestIamPermissionsRequest(service, body, project, resource);
        }

        /// <summary>Returns permissions that a caller has on the specified resource.</summary>
        public class TestIamPermissionsRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.TestPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.TestPermissionsRequest body, string project, string resource) : base(service)
            {
                Project = project;
                Resource = resource;
                Body = body;
                InitParameters();
            }


            /// <summary>Project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Name or id of the resource for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.TestPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{resource}/testIamPermissions";

            /// <summary>Initializes TestIamPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z0-9](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9_]{0,61}[a-z0-9])?|[1-9][0-9]{0,19}",
                });
            }

        }

        /// <summary>Updates a deployment and all of the resources described by the deployment manifest.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the
        /// deployment for this request.</param>
        public virtual UpdateRequest Update(Google.Apis.DeploymentManagerAlpha.alpha.Data.Deployment body, string project, string deployment)
        {
            return new UpdateRequest(service, body, project, deployment);
        }

        /// <summary>Updates a deployment and all of the resources described by the deployment manifest.</summary>
        public class UpdateRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.Deployment body, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Body = body;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("createPolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CreatePolicyEnum> CreatePolicy { get; set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            public enum CreatePolicyEnum
            {
                [Google.Apis.Util.StringValueAttribute("ACQUIRE")]
                ACQUIRE,
                [Google.Apis.Util.StringValueAttribute("CREATE")]
                CREATE,
                [Google.Apis.Util.StringValueAttribute("CREATE_OR_ACQUIRE")]
                CREATEORACQUIRE,
            }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deletePolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DeletePolicyEnum> DeletePolicy { get; set; }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            public enum DeletePolicyEnum
            {
                [Google.Apis.Util.StringValueAttribute("ABANDON")]
                ABANDON,
                [Google.Apis.Util.StringValueAttribute("DELETE")]
                DELETE,
            }

            /// <summary>If set to true, updates the deployment and creates and updates the "shell" resources but does
            /// not actually alter or instantiate these resources. This allows you to preview what your deployment will
            /// look like. You can use this intent to preview how an update would affect your deployment. You must
            /// provide a `target.config` with a configuration if this is set to true. After previewing a deployment,
            /// you can deploy your resources by making a request with the `update()` or you can `cancelPreview()` to
            /// remove the preview altogether. Note that the deployment will still exist after you cancel the preview
            /// and you must separately delete this deployment if you want to remove it.</summary>
            [Google.Apis.Util.RequestParameterAttribute("preview", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Preview { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.Deployment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{deployment}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("createPolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "createPolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "CREATE_OR_ACQUIRE",
                    Pattern = null,
                });
                RequestParameters.Add("deletePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "deletePolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "DELETE",
                    Pattern = null,
                });
                RequestParameters.Add("preview", new Google.Apis.Discovery.Parameter
                {
                    Name = "preview",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "manifests" collection of methods.</summary>
    public class ManifestsResource
    {
        private const string Resource = "manifests";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ManifestsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets information about a specific manifest.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the
        /// deployment for this request.</param>
        /// <param name="manifest">The name of the manifest for this
        /// request.</param>
        public virtual GetRequest Get(string project, string deployment, string manifest)
        {
            return new GetRequest(service, project, deployment, manifest);
        }

        /// <summary>Gets information about a specific manifest.</summary>
        public class GetRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Manifest>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string deployment, string manifest) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Manifest = manifest;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>The name of the manifest for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("manifest", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Manifest { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{deployment}/manifests/{manifest}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("manifest", new Google.Apis.Discovery.Parameter
                {
                    Name = "manifest",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
            }

        }

        /// <summary>Lists all manifests for a given deployment.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the
        /// deployment for this request.</param>
        public virtual ListRequest List(string project, string deployment)
        {
            return new ListRequest(service, project, deployment);
        }

        /// <summary>Lists all manifests for a given deployment.</summary>
        public class ListRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.ManifestsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>A filter expression that filters resources listed in the response. The expression must specify
            /// the field name, a comparison operator, and the value that you want to use for filtering. The value must
            /// be a string, a number, or a boolean. The comparison operator must be either `=`, `!=`, `>`, or `<`.
            ///
            /// For example, if you are filtering Compute Engine instances, you can exclude instances named `example-
            /// instance` by specifying `name != example-instance`.
            ///
            /// You can also filter nested fields. For example, you could specify `scheduling.automaticRestart = false`
            /// to include instances only if they are not scheduled for automatic restarts. You can use filtering on
            /// nested fields to filter based on resource labels.
            ///
            /// To filter on multiple expressions, provide each separate expression within parentheses. For example: ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake") ``` By default, each expression is
            /// an `AND` expression. However, you can include `AND` and `OR` expressions explicitly. For example: ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND (scheduling.automaticRestart =
            /// true) ```</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results per page that should be returned. If the number of available
            /// results is larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get
            /// the next page of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive.
            /// (Default: `500`)</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Sorts list results by a certain order. By default, results are returned in alphanumerical order
            /// based on the resource name.
            ///
            /// You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first.
            ///
            /// Currently, only sorting by `name` or `creationTimestamp desc` is supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous
            /// list request to get the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Opt-in for partial success behavior which provides partial results in case of failure. The
            /// default value is false and the logic is the same as today.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{deployment}/manifests";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "returnPartialSuccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

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


        /// <summary>Gets information about a specific operation.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="operation">The name of the
        /// operation for this request.</param>
        public virtual GetRequest Get(string project, string operation)
        {
            return new GetRequest(service, project, operation);
        }

        /// <summary>Gets information about a specific operation.</summary>
        public class GetRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string operation) : base(service)
            {
                Project = project;
                Operation = operation;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the operation for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("operation", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Operation { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/operations/{operation}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("operation", new Google.Apis.Discovery.Parameter
                {
                    Name = "operation",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists all operations for a project.</summary>
        /// <param name="project">The project ID for this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(service, project);
        }

        /// <summary>Lists all operations for a project.</summary>
        public class ListRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.OperationsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>A filter expression that filters resources listed in the response. The expression must specify
            /// the field name, a comparison operator, and the value that you want to use for filtering. The value must
            /// be a string, a number, or a boolean. The comparison operator must be either `=`, `!=`, `>`, or `<`.
            ///
            /// For example, if you are filtering Compute Engine instances, you can exclude instances named `example-
            /// instance` by specifying `name != example-instance`.
            ///
            /// You can also filter nested fields. For example, you could specify `scheduling.automaticRestart = false`
            /// to include instances only if they are not scheduled for automatic restarts. You can use filtering on
            /// nested fields to filter based on resource labels.
            ///
            /// To filter on multiple expressions, provide each separate expression within parentheses. For example: ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake") ``` By default, each expression is
            /// an `AND` expression. However, you can include `AND` and `OR` expressions explicitly. For example: ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND (scheduling.automaticRestart =
            /// true) ```</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results per page that should be returned. If the number of available
            /// results is larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get
            /// the next page of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive.
            /// (Default: `500`)</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Sorts list results by a certain order. By default, results are returned in alphanumerical order
            /// based on the resource name.
            ///
            /// You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first.
            ///
            /// Currently, only sorting by `name` or `creationTimestamp desc` is supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous
            /// list request to get the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Opt-in for partial success behavior which provides partial results in case of failure. The
            /// default value is false and the logic is the same as today.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/operations";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "returnPartialSuccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "resources" collection of methods.</summary>
    public class ResourcesResource
    {
        private const string Resource = "resources";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ResourcesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets information about a single resource.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the
        /// deployment for this request.</param>
        /// <param name="resource">The name of the resource for this
        /// request.</param>
        public virtual GetRequest Get(string project, string deployment, string resource)
        {
            return new GetRequest(service, project, deployment, resource);
        }

        /// <summary>Gets information about a single resource.</summary>
        public class GetRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Resource>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string deployment, string resource) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Resource = resource;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>The name of the resource for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{deployment}/resources/{resource}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists all resources in a given deployment.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the
        /// deployment for this request.</param>
        public virtual ListRequest List(string project, string deployment)
        {
            return new ListRequest(service, project, deployment);
        }

        /// <summary>Lists all resources in a given deployment.</summary>
        public class ListRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.ResourcesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>A filter expression that filters resources listed in the response. The expression must specify
            /// the field name, a comparison operator, and the value that you want to use for filtering. The value must
            /// be a string, a number, or a boolean. The comparison operator must be either `=`, `!=`, `>`, or `<`.
            ///
            /// For example, if you are filtering Compute Engine instances, you can exclude instances named `example-
            /// instance` by specifying `name != example-instance`.
            ///
            /// You can also filter nested fields. For example, you could specify `scheduling.automaticRestart = false`
            /// to include instances only if they are not scheduled for automatic restarts. You can use filtering on
            /// nested fields to filter based on resource labels.
            ///
            /// To filter on multiple expressions, provide each separate expression within parentheses. For example: ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake") ``` By default, each expression is
            /// an `AND` expression. However, you can include `AND` and `OR` expressions explicitly. For example: ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND (scheduling.automaticRestart =
            /// true) ```</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results per page that should be returned. If the number of available
            /// results is larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get
            /// the next page of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive.
            /// (Default: `500`)</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Sorts list results by a certain order. By default, results are returned in alphanumerical order
            /// based on the resource name.
            ///
            /// You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first.
            ///
            /// Currently, only sorting by `name` or `creationTimestamp desc` is supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous
            /// list request to get the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Opt-in for partial success behavior which provides partial results in case of failure. The
            /// default value is false and the logic is the same as today.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/deployments/{deployment}/resources";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "returnPartialSuccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "typeProviders" collection of methods.</summary>
    public class TypeProvidersResource
    {
        private const string Resource = "typeProviders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TypeProvidersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Deletes a type provider.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="typeProvider">The name of the
        /// type provider for this request.</param>
        public virtual DeleteRequest Delete(string project, string typeProvider)
        {
            return new DeleteRequest(service, project, typeProvider);
        }

        /// <summary>Deletes a type provider.</summary>
        public class DeleteRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string typeProvider) : base(service)
            {
                Project = project;
                TypeProvider = typeProvider;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the type provider for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("typeProvider", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TypeProvider { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/typeProviders/{typeProvider}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("typeProvider", new Google.Apis.Discovery.Parameter
                {
                    Name = "typeProvider",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
            }

        }

        /// <summary>Gets information about a specific type provider.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="typeProvider">The name of the
        /// type provider for this request.</param>
        public virtual GetRequest Get(string project, string typeProvider)
        {
            return new GetRequest(service, project, typeProvider);
        }

        /// <summary>Gets information about a specific type provider.</summary>
        public class GetRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvider>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string typeProvider) : base(service)
            {
                Project = project;
                TypeProvider = typeProvider;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the type provider for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("typeProvider", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TypeProvider { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/typeProviders/{typeProvider}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("typeProvider", new Google.Apis.Discovery.Parameter
                {
                    Name = "typeProvider",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
            }

        }

        /// <summary>Gets a type info for a type provided by a TypeProvider.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="typeProvider">The name of the
        /// type provider for this request.</param>
        /// <param name="type">The name of the type provider type for this
        /// request.</param>
        public virtual GetTypeRequest GetType(string project, string typeProvider, string type)
        {
            return new GetTypeRequest(service, project, typeProvider, type);
        }

        /// <summary>Gets a type info for a type provided by a TypeProvider.</summary>
        public class GetTypeRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeInfo>
        {
            /// <summary>Constructs a new GetType request.</summary>
            public GetTypeRequest(Google.Apis.Services.IClientService service, string project, string typeProvider, string type) : base(service)
            {
                Project = project;
                TypeProvider = typeProvider;
                Type = type;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the type provider for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("typeProvider", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TypeProvider { get; private set; }

            /// <summary>The name of the type provider type for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Type { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getType";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/typeProviders/{typeProvider}/types/{type}";

            /// <summary>Initializes GetType parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("typeProvider", new Google.Apis.Discovery.Parameter
                {
                    Name = "typeProvider",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                {
                    Name = "type",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Creates a type provider.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        public virtual InsertRequest Insert(Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvider body, string project)
        {
            return new InsertRequest(service, body, project);
        }

        /// <summary>Creates a type provider.</summary>
        public class InsertRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvider body, string project) : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvider Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/typeProviders";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
            }

        }

        /// <summary>Lists all resource type providers for Deployment Manager.</summary>
        /// <param name="project">The project ID for this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(service, project);
        }

        /// <summary>Lists all resource type providers for Deployment Manager.</summary>
        public class ListRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvidersListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>A filter expression that filters resources listed in the response. The expression must specify
            /// the field name, a comparison operator, and the value that you want to use for filtering. The value must
            /// be a string, a number, or a boolean. The comparison operator must be either `=`, `!=`, `>`, or `<`.
            ///
            /// For example, if you are filtering Compute Engine instances, you can exclude instances named `example-
            /// instance` by specifying `name != example-instance`.
            ///
            /// You can also filter nested fields. For example, you could specify `scheduling.automaticRestart = false`
            /// to include instances only if they are not scheduled for automatic restarts. You can use filtering on
            /// nested fields to filter based on resource labels.
            ///
            /// To filter on multiple expressions, provide each separate expression within parentheses. For example: ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake") ``` By default, each expression is
            /// an `AND` expression. However, you can include `AND` and `OR` expressions explicitly. For example: ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND (scheduling.automaticRestart =
            /// true) ```</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results per page that should be returned. If the number of available
            /// results is larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get
            /// the next page of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive.
            /// (Default: `500`)</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Sorts list results by a certain order. By default, results are returned in alphanumerical order
            /// based on the resource name.
            ///
            /// You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first.
            ///
            /// Currently, only sorting by `name` or `creationTimestamp desc` is supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous
            /// list request to get the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Opt-in for partial success behavior which provides partial results in case of failure. The
            /// default value is false and the logic is the same as today.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/typeProviders";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "returnPartialSuccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists all the type info for a TypeProvider.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="typeProvider">The name of the
        /// type provider for this request.</param>
        public virtual ListTypesRequest ListTypes(string project, string typeProvider)
        {
            return new ListTypesRequest(service, project, typeProvider);
        }

        /// <summary>Lists all the type info for a TypeProvider.</summary>
        public class ListTypesRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvidersListTypesResponse>
        {
            /// <summary>Constructs a new ListTypes request.</summary>
            public ListTypesRequest(Google.Apis.Services.IClientService service, string project, string typeProvider) : base(service)
            {
                Project = project;
                TypeProvider = typeProvider;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the type provider for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("typeProvider", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TypeProvider { get; private set; }

            /// <summary>A filter expression that filters resources listed in the response. The expression must specify
            /// the field name, a comparison operator, and the value that you want to use for filtering. The value must
            /// be a string, a number, or a boolean. The comparison operator must be either `=`, `!=`, `>`, or `<`.
            ///
            /// For example, if you are filtering Compute Engine instances, you can exclude instances named `example-
            /// instance` by specifying `name != example-instance`.
            ///
            /// You can also filter nested fields. For example, you could specify `scheduling.automaticRestart = false`
            /// to include instances only if they are not scheduled for automatic restarts. You can use filtering on
            /// nested fields to filter based on resource labels.
            ///
            /// To filter on multiple expressions, provide each separate expression within parentheses. For example: ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake") ``` By default, each expression is
            /// an `AND` expression. However, you can include `AND` and `OR` expressions explicitly. For example: ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND (scheduling.automaticRestart =
            /// true) ```</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results per page that should be returned. If the number of available
            /// results is larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get
            /// the next page of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive.
            /// (Default: `500`)</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Sorts list results by a certain order. By default, results are returned in alphanumerical order
            /// based on the resource name.
            ///
            /// You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first.
            ///
            /// Currently, only sorting by `name` or `creationTimestamp desc` is supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous
            /// list request to get the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Opt-in for partial success behavior which provides partial results in case of failure. The
            /// default value is false and the logic is the same as today.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listTypes";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/typeProviders/{typeProvider}/types";

            /// <summary>Initializes ListTypes parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("typeProvider", new Google.Apis.Discovery.Parameter
                {
                    Name = "typeProvider",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "returnPartialSuccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Patches a type provider.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="typeProvider">The name of the
        /// type provider for this request.</param>
        public virtual PatchRequest Patch(Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvider body, string project, string typeProvider)
        {
            return new PatchRequest(service, body, project, typeProvider);
        }

        /// <summary>Patches a type provider.</summary>
        public class PatchRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvider body, string project, string typeProvider) : base(service)
            {
                Project = project;
                TypeProvider = typeProvider;
                Body = body;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the type provider for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("typeProvider", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TypeProvider { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvider Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/typeProviders/{typeProvider}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("typeProvider", new Google.Apis.Discovery.Parameter
                {
                    Name = "typeProvider",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
            }

        }

        /// <summary>Updates a type provider.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="typeProvider">The name of the
        /// type provider for this request.</param>
        public virtual UpdateRequest Update(Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvider body, string project, string typeProvider)
        {
            return new UpdateRequest(service, body, project, typeProvider);
        }

        /// <summary>Updates a type provider.</summary>
        public class UpdateRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Operation>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvider body, string project, string typeProvider) : base(service)
            {
                Project = project;
                TypeProvider = typeProvider;
                Body = body;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the type provider for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("typeProvider", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TypeProvider { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManagerAlpha.alpha.Data.TypeProvider Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/typeProviders/{typeProvider}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("typeProvider", new Google.Apis.Discovery.Parameter
                {
                    Name = "typeProvider",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
            }

        }
    }

    /// <summary>The "types" collection of methods.</summary>
    public class TypesResource
    {
        private const string Resource = "types";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TypesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets information about a specific type.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="type">The name of the type for
        /// this request.</param>
        public virtual GetRequest Get(string project, string type)
        {
            return new GetRequest(service, project, type);
        }

        /// <summary>Gets information about a specific type.</summary>
        public class GetRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.Type>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string type) : base(service)
            {
                Project = project;
                Type = type;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the type for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Type { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/types/{type}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                {
                    Name = "type",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
            }

        }

        /// <summary>Lists all resource types for Deployment Manager.</summary>
        /// <param name="project">The project ID for this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(service, project);
        }

        /// <summary>Lists all resource types for Deployment Manager.</summary>
        public class ListRequest : DeploymentManagerAlphaBaseServiceRequest<Google.Apis.DeploymentManagerAlpha.alpha.Data.TypesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }


            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>A filter expression that filters resources listed in the response. The expression must specify
            /// the field name, a comparison operator, and the value that you want to use for filtering. The value must
            /// be a string, a number, or a boolean. The comparison operator must be either `=`, `!=`, `>`, or `<`.
            ///
            /// For example, if you are filtering Compute Engine instances, you can exclude instances named `example-
            /// instance` by specifying `name != example-instance`.
            ///
            /// You can also filter nested fields. For example, you could specify `scheduling.automaticRestart = false`
            /// to include instances only if they are not scheduled for automatic restarts. You can use filtering on
            /// nested fields to filter based on resource labels.
            ///
            /// To filter on multiple expressions, provide each separate expression within parentheses. For example: ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake") ``` By default, each expression is
            /// an `AND` expression. However, you can include `AND` and `OR` expressions explicitly. For example: ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND (scheduling.automaticRestart =
            /// true) ```</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results per page that should be returned. If the number of available
            /// results is larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get
            /// the next page of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive.
            /// (Default: `500`)</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Sorts list results by a certain order. By default, results are returned in alphanumerical order
            /// based on the resource name.
            ///
            /// You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first.
            ///
            /// Currently, only sorting by `name` or `creationTimestamp desc` is supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous
            /// list request to get the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Opt-in for partial success behavior which provides partial results in case of failure. The
            /// default value is false and the logic is the same as today.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{project}/global/types";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "returnPartialSuccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }
}

namespace Google.Apis.DeploymentManagerAlpha.alpha.Data
{    

    /// <summary>Async options that determine when a resource should finish.</summary>
    public class AsyncOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Method regex where this policy will apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodMatch")]
        public virtual string MethodMatch { get; set; } 

        /// <summary>Deployment manager will poll instances for this API resource setting a RUNNING state, and blocking
        /// until polling conditions tell whether the resource is completed or failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pollingOptions")]
        public virtual PollingOptions PollingOptions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Specifies the audit configuration for a service. The configuration determines which permission types
    /// are logged, and what identities, if any, are exempted from logging. An AuditConfig must have one or more
    /// AuditLogConfigs.
    ///
    /// If there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is
    /// used for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted.
    ///
    /// Example Policy with multiple AuditConfigs:
    ///
    /// { "audit_configs": [ { "service": "allServices" "audit_log_configs": [ { "log_type": "DATA_READ",
    /// "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE", }, { "log_type": "ADMIN_READ", }
    /// ] }, { "service": "sampleservice.googleapis.com" "audit_log_configs": [ { "log_type": "DATA_READ", }, {
    /// "log_type": "DATA_WRITE", "exempted_members": [ "user:aliya@example.com" ] } ] } ] }
    ///
    /// For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ logging. It also exempts
    /// jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.</summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; } 

        /// <summary>Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Provides the configuration for logging a type of permissions. Example:
    ///
    /// { "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, {
    /// "log_type": "DATA_WRITE", } ] }
    ///
    /// This enables 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ
    /// logging.</summary>
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies the identities that do not cause logging for this type of permission. Follows the same
        /// format of [Binding.members][].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("ignoreChildExemptions")]
        public virtual System.Nullable<bool> IgnoreChildExemptions { get; set; } 

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Authorization-related information used by Cloud Audit Logging.</summary>
    public class AuthorizationLoggingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the permission that was checked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionType")]
        public virtual string PermissionType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Basic Auth used as a credential.</summary>
    public class BasicAuth : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The condition that is associated with this binding.
        ///
        /// If the condition evaluates to `true`, then this binding applies to the current request.
        ///
        /// If the condition evaluates to `false`, then this binding does not apply to the current request. However, a
        /// different role binding might grant the same role to one or more of the members in this binding.
        ///
        /// To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; } 

        /// <summary>Specifies the identities requesting access for a Cloud Platform resource. `members` can have the
        /// following values:
        ///
        /// * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a Google
        /// account.
        ///
        /// * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated with a Google
        /// account or a service account.
        ///
        /// * `user:{emailid}`: An email address that represents a specific Google account. For example,
        /// `alice@example.com` .
        ///
        /// * `serviceAccount:{emailid}`: An email address that represents a service account. For example, `my-other-
        /// app@appspot.gserviceaccount.com`.
        ///
        /// * `group:{emailid}`: An email address that represents a Google group. For example, `admins@example.com`.
        ///
        /// * `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user
        /// that has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding.
        ///
        /// * `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a service account that has been recently deleted. For example, `my-other-
        /// app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted, this value
        /// reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the binding.
        ///
        /// * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a Google
        /// group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`. If the
        /// group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role in the
        /// binding.
        ///
        /// * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that domain. For example,
        /// `google.com` or `example.com`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; } 

        /// <summary>Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or
        /// `roles/owner`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>CollectionOverride allows resource handling overrides for specific resources within a
    /// BaseType</summary>
    public class CollectionOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The collection that identifies this resource within its service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collection")]
        public virtual string Collection { get; set; } 

        /// <summary>Custom verb method mappings to support unordered list API mappings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodMap")]
        public virtual MethodMap MethodMap { get; set; } 

        /// <summary>The options to apply to this resource-level override</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual Options Options { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Holds the composite type.</summary>
    public class CompositeType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An optional textual description of the resource; provided by the client when the resource is
        /// created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; } 

        /// <summary>Output only. Creation timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; } 

        /// <summary>Map of labels; provided by the client when the resource is created or updated. Specifically: Label
        /// keys must be between 1 and 63 characters long and must conform to the following regular expression:
        /// `[a-z]([-a-z0-9]*[a-z0-9])?` Label values must be between 0 and 63 characters long and must conform to the
        /// regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<CompositeTypeLabelEntry> Labels { get; set; } 

        /// <summary>Name of the composite type, must follow the expression:
        /// `[a-z]([-a-z0-9_.]{0,61}[a-z0-9])?`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The Operation that most recently ran, or is currently running, on this composite
        /// type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; } 

        /// <summary>Output only. Server defined URL for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>Files for the template type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateContents")]
        public virtual TemplateContents TemplateContents { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class CompositeTypeLabelEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response that returns all Composite Types supported by Deployment Manager</summary>
    public class CompositeTypesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A list of resource composite types supported by Deployment Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compositeTypes")]
        public virtual System.Collections.Generic.IList<CompositeType> CompositeTypes { get; set; } 

        /// <summary>A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A condition to be met.</summary>
    public class Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Trusted attributes supplied by the IAM system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iam")]
        public virtual string Iam { get; set; } 

        /// <summary>An operator to apply the subject with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("op")]
        public virtual string Op { get; set; } 

        /// <summary>Trusted attributes discharged by the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("svc")]
        public virtual string Svc { get; set; } 

        /// <summary>Trusted attributes supplied by any service that owns resources and uses the IAM system for access
        /// control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sys")]
        public virtual string Sys { get; set; } 

        /// <summary>The objects of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ConfigFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contents of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>BaseType that describes a service-backed Type.</summary>
    public class ConfigurableService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allows resource handling overrides for specific collections</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionOverrides")]
        public virtual System.Collections.Generic.IList<CollectionOverride> CollectionOverrides { get; set; } 

        /// <summary>Credential used when interacting with this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credential")]
        public virtual Credential Credential { get; set; } 

        /// <summary>Descriptor Url for the this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descriptorUrl")]
        public virtual string DescriptorUrl { get; set; } 

        /// <summary>Options to apply when handling any resources in this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual Options Options { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The credential used by Deployment Manager and TypeProvider. Only one of the options is
    /// permitted.</summary>
    public class Credential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic Auth Credential, only used by TypeProvider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicAuth")]
        public virtual BasicAuth BasicAuth { get; set; } 

        /// <summary>Service Account Credential, only used by Deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual ServiceAccount ServiceAccount { get; set; } 

        /// <summary>Specify to use the project default credential, only supported by Deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useProjectDefault")]
        public virtual System.Nullable<bool> UseProjectDefault { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Deployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User provided default credential for the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credential")]
        public virtual Credential Credential { get; set; } 

        /// <summary>An optional user-provided description of the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Provides a fingerprint to use in requests to modify a deployment, such as `update()`, `stop()`, and
        /// `cancelPreview()` requests. A fingerprint is a randomly generated value that must be provided with
        /// `update()`, `stop()`, and `cancelPreview()` requests to perform optimistic locking. This ensures optimistic
        /// concurrency so that only one request happens at a time.
        ///
        /// The fingerprint is initially generated by Deployment Manager and changes after every request to modify data.
        /// To get the latest fingerprint value, perform a `get()` request to a deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; } 

        /// <summary>Output only. Creation timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; } 

        /// <summary>Map of labels; provided by the client when the resource is created or updated. Specifically: Label
        /// keys must be between 1 and 63 characters long and must conform to the following regular expression:
        /// `[a-z]([-a-z0-9]*[a-z0-9])?` Label values must be between 0 and 63 characters long and must conform to the
        /// regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<DeploymentLabelEntry> Labels { get; set; } 

        /// <summary>Output only. URL of the manifest representing the last manifest that was successfully deployed. If
        /// no manifest has been successfully deployed, this field will be absent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifest")]
        public virtual string Manifest { get; set; } 

        /// <summary>Name of the resource; provided by the client when the resource is created. The name must be 1-63
        /// characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the
        /// regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter,
        /// and all following characters must be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The Operation that most recently ran, or is currently running, on this
        /// deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; } 

        /// <summary>Output only. List of outputs from the last manifest that deployed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputs")]
        public virtual System.Collections.Generic.IList<DeploymentOutputEntry> Outputs { get; set; } 

        /// <summary>Output only. Server defined URL for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        /// <summary>[Input Only] The parameters that define your deployment, including the deployment configuration and
        /// relevant templates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual TargetConfiguration Target { get; set; } 

        /// <summary>Output only. If Deployment Manager is currently updating or previewing an update to this
        /// deployment, the updated configuration appears here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual DeploymentUpdate Update { get; set; } 

        /// <summary>Output only. Update timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DeploymentLabelEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output object for Deployments</summary>
    public class DeploymentOutputEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key of the output</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        /// <summary>Value of the label</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DeploymentUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The user-provided default credential to use when deploying this preview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credential")]
        public virtual Credential Credential { get; set; } 

        /// <summary>Output only. An optional user-provided description of the deployment after the current update has
        /// been applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Output only. Map of labels; provided by the client when the resource is created or updated.
        /// Specifically: Label keys must be between 1 and 63 characters long and must conform to the following regular
        /// expression: `[a-z]([-a-z0-9]*[a-z0-9])?` Label values must be between 0 and 63 characters long and must
        /// conform to the regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<DeploymentUpdateLabelEntry> Labels { get; set; } 

        /// <summary>Output only. URL of the manifest representing the update configuration of this
        /// deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifest")]
        public virtual string Manifest { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DeploymentUpdateLabelEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DeploymentsCancelPreviewRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies a fingerprint for `cancelPreview()` requests. A fingerprint is a randomly generated value
        /// that must be provided in `cancelPreview()` requests to perform optimistic locking. This ensures optimistic
        /// concurrency so that the deployment does not have conflicting requests (e.g. if someone attempts to make a
        /// new update request while another user attempts to cancel a preview, this would prevent one of the requests).
        ///
        /// The fingerprint is initially generated by Deployment Manager and changes after every request to modify a
        /// deployment. To get the latest fingerprint value, perform a `get()` request on the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response containing a partial list of deployments and a page token used to build the next request if
    /// the request has been truncated.</summary>
    public class DeploymentsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The deployments contained in this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployments")]
        public virtual System.Collections.Generic.IList<Deployment> Deployments { get; set; } 

        /// <summary>Output only. A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DeploymentsStopRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies a fingerprint for `stop()` requests. A fingerprint is a randomly generated value that
        /// must be provided in `stop()` requests to perform optimistic locking. This ensures optimistic concurrency so
        /// that the deployment does not have conflicting requests (e.g. if someone attempts to make a new update
        /// request while another user attempts to stop an ongoing update request, this would prevent a collision).
        ///
        /// The fingerprint is initially generated by Deployment Manager and changes after every request to modify a
        /// deployment. To get the latest fingerprint value, perform a `get()` request on the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Diagnostic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>JsonPath expression on the resource that if non empty, indicates that this field needs to be
        /// extracted as a diagnostic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; } 

        /// <summary>Level to record this diagnostic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like
    /// expression language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec.
    ///
    /// Example (Comparison):
    ///
    /// title: "Summary size limit" description: "Determines if a summary is less than 100 chars" expression:
    /// "document.summary.size() < 100"
    ///
    /// Example (Equality):
    ///
    /// title: "Requestor is owner" description: "Determines if requestor is the document owner" expression:
    /// "document.owner == request.auth.claims.email"
    ///
    /// Example (Logic):
    ///
    /// title: "Public documents" description: "Determine whether the document should be publicly visible" expression:
    /// "document.type != 'private' && document.type != 'internal'"
    ///
    /// Example (Data Manipulation):
    ///
    /// title: "Notification string" description: "Create a notification string with a timestamp." expression: "'New
    /// message received at ' + string(document.create_time)"
    ///
    /// The exact variables and functions that may be referenced within an expression are determined by the service that
    /// evaluates it. See the service documentation for additional information.</summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g.
        /// when hovered over it in a UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; } 

        /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name
        /// and a position in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; } 

        /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used
        /// e.g. in UIs which allow to enter the expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GlobalSetPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Flatten Policy to create a backward compatible wire-format. Deprecated. Use 'policy' to specify
        /// bindings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; } 

        /// <summary>Flatten Policy to create a backward compatible wire-format. Deprecated. Use 'policy' to specify the
        /// etag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>REQUIRED: The complete policy to be applied to the 'resource'. The size of the policy is limited to
        /// a few 10s of KB. An empty policy is in general a valid policy but certain services (like Projects) might
        /// reject them.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; } 

    }    

    public class ImportFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contents of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; } 

        /// <summary>The name of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>InputMapping creates a 'virtual' property that will be injected into the properties before sending the
    /// request to the underlying API.</summary>
    public class InputMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the field that is going to be injected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; } 

        /// <summary>The location where this mapping applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; } 

        /// <summary>Regex to evaluate on method to decide if input applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodMatch")]
        public virtual string MethodMatch { get; set; } 

        /// <summary>A jsonPath expression to select an element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Specifies what kind of log the caller must write</summary>
    public class LogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud audit options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudAudit")]
        public virtual LogConfigCloudAuditOptions CloudAudit { get; set; } 

        /// <summary>Counter options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counter")]
        public virtual LogConfigCounterOptions Counter { get; set; } 

        /// <summary>Data access options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataAccess")]
        public virtual LogConfigDataAccessOptions DataAccess { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Write a Cloud Audit log</summary>
    public class LogConfigCloudAuditOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information used by the Cloud Audit Logging pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationLoggingOptions")]
        public virtual AuthorizationLoggingOptions AuthorizationLoggingOptions { get; set; } 

        /// <summary>The log_name to populate in the Cloud Audit Record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logName")]
        public virtual string LogName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Increment a streamz counter with the specified metric and field names.
    ///
    /// Metric names should start with a '/', generally be lowercase-only, and end in "_count". Field names should not
    /// contain an initial slash. The actual exported metric names will have "/iam/policy" prepended.
    ///
    /// Field names correspond to IAM request parameters and field values are their respective values.
    ///
    /// Supported field names: - "authority", which is "[token]" if IAMContext.token is present, otherwise the value of
    /// IAMContext.authority_selector if present, and otherwise a representation of IAMContext.principal; or -
    /// "iam_principal", a representation of IAMContext.principal even if a token or authority selector is present; or -
    /// "" (empty string), resulting in a counter with no fields.
    ///
    /// Examples: counter { metric: "/debug_access_count" field: "iam_principal" } ==> increment counter
    /// /iam/policy/debug_access_count {iam_principal=[value of IAMContext.principal]}</summary>
    public class LogConfigCounterOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFields")]
        public virtual System.Collections.Generic.IList<LogConfigCounterOptionsCustomField> CustomFields { get; set; } 

        /// <summary>The field value to attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; } 

        /// <summary>The metric to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Custom fields. These can be used to create a counter with arbitrary field/value pairs. See: go/rpcsp-
    /// custom-fields.</summary>
    public class LogConfigCounterOptionsCustomField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name is the field name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Value is the field value. It is important that in contrast to the CounterOptions.field, the value
        /// here is a constant that is not derived from the IAMContext.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Write a Data Access (Gin) log</summary>
    public class LogConfigDataAccessOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("logMode")]
        public virtual string LogMode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Manifest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The YAML configuration for this manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual ConfigFile Config { get; set; } 

        /// <summary>Output only. The fully-expanded configuration file, including any templates and
        /// references.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandedConfig")]
        public virtual string ExpandedConfig { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; } 

        /// <summary>Output only. The imported files for this manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imports")]
        public virtual System.Collections.Generic.IList<ImportFile> Imports { get; set; } 

        /// <summary>Output only. Creation timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; } 

        /// <summary>Output only. The YAML layout for this manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual string Layout { get; set; } 

        /// <summary>Output only.
        ///
        /// The name of the manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. Self link for the manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response containing a partial list of manifests and a page token used to build the next request if
    /// the request has been truncated.</summary>
    public class ManifestsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Manifests contained in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifests")]
        public virtual System.Collections.Generic.IList<Manifest> Manifests { get; set; } 

        /// <summary>Output only. A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deployment Manager will call these methods during the events of
    /// creation/deletion/update/get/setIamPolicy</summary>
    public class MethodMap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action identifier for the create method to be used for this collection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("create")]
        public virtual string Create { get; set; } 

        /// <summary>The action identifier for the delete method to be used for this collection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delete")]
        public virtual string Delete { get; set; } 

        /// <summary>The action identifier for the get method to be used for this collection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("get")]
        public virtual string Get { get; set; } 

        /// <summary>The action identifier for the setIamPolicy method to be used for this collection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setIamPolicy")]
        public virtual string SetIamPolicy { get; set; } 

        /// <summary>The action identifier for the update method to be used for this collection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual string Update { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an Operation resource.
    ///
    /// Google Compute Engine has three Operation resources:
    ///
    /// * [Global](/compute/docs/reference/rest/{$api_version}/globalOperations) *
    /// [Regional](/compute/docs/reference/rest/{$api_version}/regionOperations) *
    /// [Zonal](/compute/docs/reference/rest/{$api_version}/zoneOperations)
    ///
    /// You can use an operation resource to manage asynchronous API requests. For more information, read Handling API
    /// responses.
    ///
    /// Operations can be global, regional or zonal. - For global operations, use the `globalOperations` resource. - For
    /// regional operations, use the `regionOperations` resource. - For zonal operations, use the `zonalOperations`
    /// resource.
    ///
    /// For more information, read  Global, Regional, and Zonal Resources. (== resource_for
    /// {$api_version}.globalOperations ==) (== resource_for {$api_version}.regionOperations ==) (== resource_for
    /// {$api_version}.zoneOperations ==)</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output Only] The value of `requestId` if you provided it in the request. Not present
        /// otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientOperationId")]
        public virtual string ClientOperationId { get; set; } 

        /// <summary>[Deprecated] This field is deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTimestamp")]
        public virtual string CreationTimestamp { get; set; } 

        /// <summary>[Output Only] A textual description of the operation, which is set when the operation is
        /// created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>[Output Only] The time that this operation was completed. This value is in RFC3339 text
        /// format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTime { get; set; } 

        /// <summary>[Output Only] If errors are generated during processing of the operation, this field will be
        /// populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual ErrorData Error { get; set; } 

        /// <summary>[Output Only] If the operation fails, this field contains the HTTP error message that was returned,
        /// such as `NOT FOUND`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpErrorMessage")]
        public virtual string HttpErrorMessage { get; set; } 

        /// <summary>[Output Only] If the operation fails, this field contains the HTTP error status code that was
        /// returned. For example, a `404` means the resource was not found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpErrorStatusCode")]
        public virtual System.Nullable<int> HttpErrorStatusCode { get; set; } 

        /// <summary>[Output Only] The unique identifier for the operation. This identifier is defined by the
        /// server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; } 

        /// <summary>[Output Only] The time that this operation was requested. This value is in RFC3339 text
        /// format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; } 

        /// <summary>[Output Only] Type of the resource. Always `compute#operation` for Operation resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>[Output Only] Name of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>[Output Only] The type of operation, such as `insert`, `update`, or `delete`, and so on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; } 

        /// <summary>[Output Only] An optional progress indicator that ranges from 0 to 100. There is no requirement
        /// that this be linear or support any granularity of operations. This should not be used to guess when the
        /// operation will be complete. This number should monotonically increase as the operation progresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual System.Nullable<int> Progress { get; set; } 

        /// <summary>[Output Only] The URL of the region where the operation resides. Only applicable when performing
        /// regional operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>[Output Only] Server-defined URL for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        /// <summary>[Output Only] Server-defined URL for this resource with the resource id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLinkWithId")]
        public virtual string SelfLinkWithId { get; set; } 

        /// <summary>[Output Only] The time that this operation was started by the server. This value is in RFC3339 text
        /// format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; } 

        /// <summary>[Output Only] The status of the operation, which can be one of the following: `PENDING`, `RUNNING`,
        /// or `DONE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>[Output Only] An optional textual description of the current status of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; } 

        /// <summary>[Output Only] The unique target ID, which identifies a specific incarnation of the target
        /// resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual System.Nullable<ulong> TargetId { get; set; } 

        /// <summary>[Output Only] The URL of the resource that the operation modifies. For operations related to
        /// creating a snapshot, this points to the persistent disk that the snapshot was created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLink")]
        public virtual string TargetLink { get; set; } 

        /// <summary>[Output Only] User who requested the operation, for example: `user@example.com`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; } 

        /// <summary>[Output Only] If warning messages are generated during processing of the operation, this field will
        /// be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<WarningsData> Warnings { get; set; } 

        /// <summary>[Output Only] The URL of the zone where the operation resides. Only applicable when performing per-
        /// zone operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        /// <summary>[Output Only] If errors are generated during processing of the operation, this field will be
        /// populated.</summary>
        public class ErrorData
        {
            /// <summary>[Output Only] The array of errors encountered while processing this operation.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("errors")]
            public virtual System.Collections.Generic.IList<ErrorsData> Errors { get; set; } 

            

            public class ErrorsData
            {
                /// <summary>[Output Only] The error type identifier for this error.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("code")]
                public virtual string Code { get; set; } 

                /// <summary>[Output Only] Indicates the field in the request that caused the error. This property is
                /// optional.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("location")]
                public virtual string Location { get; set; } 

                /// <summary>[Output Only] An optional, human-readable error message.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("message")]
                public virtual string Message { get; set; } 

            }
        }    

        public class WarningsData
        {
            /// <summary>[Output Only] A warning code, if applicable. For example, Compute Engine returns
            /// NO_RESULTS_ON_PAGE if there are no results in the response.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("code")]
            public virtual string Code { get; set; } 

            /// <summary>[Output Only] Metadata about this warning in key: value format. For example: "data": [ { "key":
            /// "scope", "value": "zones/us-east1-d" }</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("data")]
            public virtual System.Collections.Generic.IList<DataData> Data { get; set; } 

            /// <summary>[Output Only] A human-readable description of the warning code.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("message")]
            public virtual string Message { get; set; } 

            

            public class DataData
            {
                /// <summary>[Output Only] A key that provides more detail on the warning being returned. For example,
                /// for warnings where there are no results in a list request for a particular zone, this key might be
                /// scope and the key value might be the zone name. Other examples might be a key indicating a
                /// deprecated resource and a suggested replacement, or a warning about invalid network settings (for
                /// example, if an instance attempts to perform IP forwarding but is not enabled for IP
                /// forwarding).</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("key")]
                public virtual string Key { get; set; } 

                /// <summary>[Output Only] A warning data value corresponding to the key.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value { get; set; } 

            }
        }
    }    

    /// <summary>A response containing a partial list of operations and a page token used to build the next request if
    /// the request has been truncated.</summary>
    public class OperationsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>Output only. Operations contained in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Options allows customized resource handling by Deployment Manager.</summary>
    public class Options : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Options regarding how to thread async requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asyncOptions")]
        public virtual System.Collections.Generic.IList<AsyncOptions> AsyncOptions { get; set; } 

        /// <summary>The mappings that apply for requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputMappings")]
        public virtual System.Collections.Generic.IList<InputMapping> InputMappings { get; set; } 

        /// <summary>The json path to the field in the resource JSON body into which the resource name should be mapped.
        /// Leaving this empty indicates that there should be no mapping performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameProperty")]
        public virtual string NameProperty { get; set; } 

        /// <summary>Options for how to validate and process properties on a resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationOptions")]
        public virtual ValidationOptions ValidationOptions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud
    /// resources.
    ///
    /// A `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members
    /// can be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list
    /// of permissions; each `role` can be an IAM predefined role or a user-created custom role.
    ///
    /// For some types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical
    /// expression that allows access to a resource only if the expression evaluates to `true`. A condition can add
    /// constraints based on attributes of the request, the resource, or both. To learn which resources support
    /// conditions in their IAM policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions
    /// /resource-policies).
    ///
    /// **JSON example:**
    ///
    /// { "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// < timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 }
    ///
    /// **YAML example:**
    ///
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com - serviceAccount:my-
    /// project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin - members: -
    /// user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable access
    /// description: Does not grant access after Sep 2020 expression: request.time <
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3
    ///
    /// For a description of IAM and its features, see the [IAM
    /// documentation](https://cloud.google.com/iam/docs/).</summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; } 

        /// <summary>Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines
        /// how and when the `bindings` are applied. Each of the `bindings` must contain at least one member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; } 

        /// <summary>`etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of
        /// a policy from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy.
        ///
        /// **Important:** If you use IAM Conditions, you must include the `etag` field whenever you call
        /// `setIamPolicy`. If you omit this field, then IAM allows you to overwrite a version `3` policy with a version
        /// `1` policy, and all of the conditions in the version `3` policy are lost.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("iamOwned")]
        public virtual System.Nullable<bool> IamOwned { get; set; } 

        /// <summary>If more than one rule is specified, the rules are applied in the following manner: - All matching
        /// LOG rules are always applied. - If any DENY/DENY_WITH_LOG rule matches, permission is denied. Logging will
        /// be applied if one or more matching rule requires logging. - Otherwise, if any ALLOW/ALLOW_WITH_LOG rule
        /// matches, permission is granted. Logging will be applied if one or more matching rule requires logging. -
        /// Otherwise, if no rule applies, permission is denied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<Rule> Rules { get; set; } 

        /// <summary>Specifies the format of the policy.
        ///
        /// Valid values are `0`, `1`, and `3`. Requests that specify an invalid value are rejected.
        ///
        /// Any operation that affects conditional role bindings must specify version `3`. This requirement applies to
        /// the following operations:
        ///
        /// * Getting a policy that includes a conditional role binding * Adding a conditional role binding to a policy
        /// * Changing a conditional role binding in a policy * Removing any role binding, with or without a condition,
        /// from a policy that includes conditions
        ///
        /// **Important:** If you use IAM Conditions, you must include the `etag` field whenever you call
        /// `setIamPolicy`. If you omit this field, then IAM allows you to overwrite a version `3` policy with a version
        /// `1` policy, and all of the conditions in the version `3` policy are lost.
        ///
        /// If a policy does not include any conditions, operations on that policy may specify any valid version or
        /// leave the field unset.
        ///
        /// To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; } 

    }    

    public class PollingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of diagnostics to be collected by Deployment Manager, these diagnostics will be displayed
        /// to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnostics")]
        public virtual System.Collections.Generic.IList<Diagnostic> Diagnostics { get; set; } 

        /// <summary>JsonPath expression that determines if the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failCondition")]
        public virtual string FailCondition { get; set; } 

        /// <summary>JsonPath expression that determines if the request is completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishCondition")]
        public virtual string FinishCondition { get; set; } 

        /// <summary>JsonPath expression that evaluates to string, it indicates where to poll.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pollingLink")]
        public virtual string PollingLink { get; set; } 

        /// <summary>JsonPath expression, after polling is completed, indicates where to fetch the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLink")]
        public virtual string TargetLink { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Access Control Policy set on this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessControl")]
        public virtual ResourceAccessControl AccessControl { get; set; } 

        /// <summary>Output only. The evaluated properties of the resource with references expanded. Returned as
        /// serialized YAML.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalProperties")]
        public virtual string FinalProperties { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; } 

        /// <summary>Output only. Creation timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; } 

        /// <summary>Output only. The last used credential that successfully created/updated the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUsedCredential")]
        public virtual Credential LastUsedCredential { get; set; } 

        /// <summary>Output only. URL of the manifest representing the current configuration of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifest")]
        public virtual string Manifest { get; set; } 

        /// <summary>Output only. The name of the resource as it appears in the YAML config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The current properties of the resource before any references have been filled in.
        /// Returned as serialized YAML.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual string Properties { get; set; } 

        /// <summary>Output only. In case this is an action, it will show the runtimePolicies on which this action will
        /// run in the deployment</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimePolicies")]
        public virtual System.Collections.Generic.IList<string> RuntimePolicies { get; set; } 

        /// <summary>Output only. The type of the resource, for example `compute.v1.instance`, or
        /// `cloudfunctions.v1beta1.function`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Output only. If Deployment Manager is currently updating or previewing an update to this resource,
        /// the updated configuration appears here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual ResourceUpdate Update { get; set; } 

        /// <summary>Output only. Update timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTime { get; set; } 

        /// <summary>Output only. The URL of the actual resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>Output only. If warning messages are generated during processing of this resource, this field will
        /// be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<WarningsData> Warnings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        public class WarningsData
        {
            /// <summary>[Output Only] A warning code, if applicable. For example, Compute Engine returns
            /// NO_RESULTS_ON_PAGE if there are no results in the response.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("code")]
            public virtual string Code { get; set; } 

            /// <summary>[Output Only] Metadata about this warning in key: value format. For example: "data": [ { "key":
            /// "scope", "value": "zones/us-east1-d" }</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("data")]
            public virtual System.Collections.Generic.IList<DataData> Data { get; set; } 

            /// <summary>[Output Only] A human-readable description of the warning code.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("message")]
            public virtual string Message { get; set; } 

            

            public class DataData
            {
                /// <summary>[Output Only] A key that provides more detail on the warning being returned. For example,
                /// for warnings where there are no results in a list request for a particular zone, this key might be
                /// scope and the key value might be the zone name. Other examples might be a key indicating a
                /// deprecated resource and a suggested replacement, or a warning about invalid network settings (for
                /// example, if an instance attempts to perform IP forwarding but is not enabled for IP
                /// forwarding).</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("key")]
                public virtual string Key { get; set; } 

                /// <summary>[Output Only] A warning data value corresponding to the key.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value { get; set; } 

            }
        }
    }    

    /// <summary>The access controls set on the resource.</summary>
    public class ResourceAccessControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The GCP IAM Policy to set on the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpIamPolicy")]
        public virtual string GcpIamPolicy { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ResourceUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Access Control Policy to set on this resource after updating the resource itself.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessControl")]
        public virtual ResourceAccessControl AccessControl { get; set; } 

        /// <summary>Output only. The credential that will be used creating/updating this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credential")]
        public virtual Credential Credential { get; set; } 

        /// <summary>Output only. If errors are generated during update of the resource, this field will be
        /// populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual ErrorData Error { get; set; } 

        /// <summary>Output only. The expanded properties of the resource with reference values expanded. Returned as
        /// serialized YAML.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalProperties")]
        public virtual string FinalProperties { get; set; } 

        /// <summary>Output only. The intent of the resource: `PREVIEW`, `UPDATE`, or `CANCEL`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intent")]
        public virtual string Intent { get; set; } 

        /// <summary>Output only. URL of the manifest representing the update configuration of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifest")]
        public virtual string Manifest { get; set; } 

        /// <summary>Output only. The set of updated properties for this resource, before references are expanded.
        /// Returned as serialized YAML.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual string Properties { get; set; } 

        /// <summary>Output only. In case this is an action, it will show the runtimePolicies that this action will have
        /// after updating the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimePolicies")]
        public virtual System.Collections.Generic.IList<string> RuntimePolicies { get; set; } 

        /// <summary>Output only. The state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>Output only. If warning messages are generated during processing of this resource, this field will
        /// be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<WarningsData> Warnings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        /// <summary>Output only. If errors are generated during update of the resource, this field will be
        /// populated.</summary>
        public class ErrorData
        {
            /// <summary>[Output Only] The array of errors encountered while processing this operation.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("errors")]
            public virtual System.Collections.Generic.IList<ErrorsData> Errors { get; set; } 

            

            public class ErrorsData
            {
                /// <summary>[Output Only] The error type identifier for this error.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("code")]
                public virtual string Code { get; set; } 

                /// <summary>[Output Only] Indicates the field in the request that caused the error. This property is
                /// optional.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("location")]
                public virtual string Location { get; set; } 

                /// <summary>[Output Only] An optional, human-readable error message.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("message")]
                public virtual string Message { get; set; } 

            }
        }    

        public class WarningsData
        {
            /// <summary>[Output Only] A warning code, if applicable. For example, Compute Engine returns
            /// NO_RESULTS_ON_PAGE if there are no results in the response.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("code")]
            public virtual string Code { get; set; } 

            /// <summary>[Output Only] Metadata about this warning in key: value format. For example: "data": [ { "key":
            /// "scope", "value": "zones/us-east1-d" }</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("data")]
            public virtual System.Collections.Generic.IList<DataData> Data { get; set; } 

            /// <summary>[Output Only] A human-readable description of the warning code.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("message")]
            public virtual string Message { get; set; } 

            

            public class DataData
            {
                /// <summary>[Output Only] A key that provides more detail on the warning being returned. For example,
                /// for warnings where there are no results in a list request for a particular zone, this key might be
                /// scope and the key value might be the zone name. Other examples might be a key indicating a
                /// deprecated resource and a suggested replacement, or a warning about invalid network settings (for
                /// example, if an instance attempts to perform IP forwarding but is not enabled for IP
                /// forwarding).</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("key")]
                public virtual string Key { get; set; } 

                /// <summary>[Output Only] A warning data value corresponding to the key.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value { get; set; } 

            }
        }
    }    

    /// <summary>A response containing a partial list of resources and a page token used to build the next request if
    /// the request has been truncated.</summary>
    public class ResourcesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>Resources contained in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<Resource> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A rule to be applied in a Policy.</summary>
    public class Rule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; } 

        /// <summary>Additional restrictions that must be met. All conditions must pass for the rule to match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<Condition> Conditions { get; set; } 

        /// <summary>Human-readable description of the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>If one or more 'in' clauses are specified, the rule matches if the PRINCIPAL/AUTHORITY_SELECTOR is
        /// in at least one of these entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ins")]
        public virtual System.Collections.Generic.IList<string> Ins { get; set; } 

        /// <summary>The config returned to callers of tech.iam.IAM.CheckPolicy for any entries that match the LOG
        /// action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logConfigs")]
        public virtual System.Collections.Generic.IList<LogConfig> LogConfigs { get; set; } 

        /// <summary>If one or more 'not_in' clauses are specified, the rule matches if the PRINCIPAL/AUTHORITY_SELECTOR
        /// is in none of the entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notIns")]
        public virtual System.Collections.Generic.IList<string> NotIns { get; set; } 

        /// <summary>A permission is a string of form '..' (e.g., 'storage.buckets.list'). A value of '*' matches all
        /// permissions, and a verb part of '*' (e.g., 'storage.buckets.*') matches all verbs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Service Account used as a credential.</summary>
    public class ServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IAM service account email address like test@myproject.iam.gserviceaccount.com</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TargetConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration to use for this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual ConfigFile Config { get; set; } 

        /// <summary>Specifies any files to import for this configuration. This can be used to import templates or other
        /// files. For example, you might import a text file in order to use the file in a template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imports")]
        public virtual System.Collections.Generic.IList<ImportFile> Imports { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Files that make up the template contents of a template type.</summary>
    public class TemplateContents : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Import files referenced by the main template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imports")]
        public virtual System.Collections.Generic.IList<ImportFile> Imports { get; set; } 

        /// <summary>Which interpreter (python or jinja) should be used during expansion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interpreter")]
        public virtual string Interpreter { get; set; } 

        /// <summary>The filename of the mainTemplate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainTemplate")]
        public virtual string MainTemplate { get; set; } 

        /// <summary>The contents of the template schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual string Schema { get; set; } 

        /// <summary>The contents of the main template file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual string Template { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TestPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of permissions to check for the 'resource'. Permissions with wildcards (such as '*' or
        /// 'storage.*') are not allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TestPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A resource type supported by Deployment Manager.</summary>
    public class Type : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Base Type (configurable service) that backs this Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurableService")]
        public virtual ConfigurableService ConfigurableService { get; set; } 

        /// <summary>An optional textual description of the resource; provided by the client when the resource is
        /// created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; } 

        /// <summary>Output only. Creation timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; } 

        /// <summary>Map of labels; provided by the client when the resource is created or updated. Specifically: Label
        /// keys must be between 1 and 63 characters long and must conform to the following regular expression:
        /// `[a-z]([-a-z0-9]*[a-z0-9])?` Label values must be between 0 and 63 characters long and must conform to the
        /// regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<TypeLabelEntry> Labels { get; set; } 

        /// <summary>Name of the type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The Operation that most recently ran, or is currently running, on this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; } 

        /// <summary>Output only. Server defined URL for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Type Information. Contains detailed information about a composite type, base type, or base type with
    /// specific collection.</summary>
    public class TypeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>For swagger 2.0 externalDocs field will be used. For swagger 1.2 this field will be
        /// empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationLink")]
        public virtual string DocumentationLink { get; set; } 

        /// <summary>Output only. Type of the output. Always `deploymentManager#TypeInfo` for TypeInfo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The base type or composite type name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>For base types with a collection, we return a schema and documentation link For template types, we
        /// return only a schema</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TypeInfoSchemaInfo Schema { get; set; } 

        /// <summary>Output only. Self link for the type provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        /// <summary>The title on the API descriptor URL provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TypeInfoSchemaInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The properties that this composite type or base type collection accept as input, represented as a
        /// json blob, format is: JSON Schema Draft V4</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual string Input { get; set; } 

        /// <summary>The properties that this composite type or base type collection exposes as output, these properties
        /// can be used for references, represented as json blob, format is: JSON Schema Draft V4</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("output")]
        public virtual string Output { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TypeLabelEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A type provider that describes a service-backed Type.</summary>
    public class TypeProvider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allows resource handling overrides for specific collections</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionOverrides")]
        public virtual System.Collections.Generic.IList<CollectionOverride> CollectionOverrides { get; set; } 

        /// <summary>Credential used when interacting with this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credential")]
        public virtual Credential Credential { get; set; } 

        /// <summary>List of up to 2 custom certificate authority roots to use for TLS authentication when making calls
        /// on behalf of this type provider. If set, TLS authentication will exclusively use these roots instead of
        /// relying on publicly trusted certificate authorities when validating TLS certificate authenticity. The
        /// certificates must be in base64-encoded PEM format. The maximum size of each certificate must not exceed
        /// 10KB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customCertificateAuthorityRoots")]
        public virtual System.Collections.Generic.IList<string> CustomCertificateAuthorityRoots { get; set; } 

        /// <summary>An optional textual description of the resource; provided by the client when the resource is
        /// created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Descriptor Url for the this type provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descriptorUrl")]
        public virtual string DescriptorUrl { get; set; } 

        /// <summary>Output only. Unique identifier for the resource defined by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; } 

        /// <summary>Output only. Creation timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; } 

        /// <summary>Map of labels; provided by the client when the resource is created or updated. Specifically: Label
        /// keys must be between 1 and 63 characters long and must conform to the following regular expression:
        /// `[a-z]([-a-z0-9]*[a-z0-9])?` Label values must be between 0 and 63 characters long and must conform to the
        /// regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<TypeProviderLabelEntry> Labels { get; set; } 

        /// <summary>Name of the resource; provided by the client when the resource is created. The name must be 1-63
        /// characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the
        /// regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter,
        /// and all following characters must be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The Operation that most recently ran, or is currently running, on this type
        /// provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; } 

        /// <summary>Options to apply when handling any resources in this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual Options Options { get; set; } 

        /// <summary>Output only. Self link for the type provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TypeProviderLabelEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response that returns all Type Providers supported by Deployment Manager</summary>
    public class TypeProvidersListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>Output only. A list of resource type providers supported by Deployment Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeProviders")]
        public virtual System.Collections.Generic.IList<TypeProvider> TypeProviders { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TypeProvidersListTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>Output only. A list of resource type info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<TypeInfo> Types { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response that returns all Types supported by Deployment Manager</summary>
    public class TypesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>Output only. A list of resource types supported by Deployment Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<Type> Types { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Options for how to validate and process properties on a resource.</summary>
    public class ValidationOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customize how deployment manager will validate the resource against schema errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaValidation")]
        public virtual string SchemaValidation { get; set; } 

        /// <summary>Specify what to do with extra properties when executing a request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("undeclaredProperties")]
        public virtual string UndeclaredProperties { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
