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

namespace Google.Apis.CloudFunctions.v2alpha
{
    /// <summary>The CloudFunctions Service.</summary>
    public class CloudFunctionsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudFunctionsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudFunctionsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudfunctions";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudfunctions.googleapis.com/";
        #else
            "https://cloudfunctions.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudfunctions.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Functions API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Functions API.</summary>
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

    /// <summary>A base abstract class for CloudFunctions requests.</summary>
    public abstract class CloudFunctionsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudFunctionsBaseServiceRequest instance.</summary>
        protected CloudFunctionsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudFunctions parameter list.</summary>
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
                Functions = new FunctionsResource(service);
                Operations = new OperationsResource(service);
                Runtimes = new RuntimesResource(service);
            }

            /// <summary>Gets the Functions resource.</summary>
            public virtual FunctionsResource Functions { get; }

            /// <summary>The "functions" collection of methods.</summary>
            public class FunctionsResource
            {
                private const string Resource = "functions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FunctionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a new function. If a function with the given name already exists in the specified project,
                /// the long running operation will return `ALREADY_EXISTS` error.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The project and location in which the function should be created, specified in the format
                /// `projects/*/locations/*`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudFunctions.v2alpha.Data.Function body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new function. If a function with the given name already exists in the specified project,
                /// the long running operation will return `ALREADY_EXISTS` error.
                /// </summary>
                public class CreateRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFunctions.v2alpha.Data.Function body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location in which the function should be created, specified in the
                    /// format `projects/*/locations/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The ID to use for the function, which will become the final component of the function's resource
                    /// name. This value should be 4-63 characters, and valid characters are /a-z-/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("functionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FunctionId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFunctions.v2alpha.Data.Function Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+parent}/functions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("functionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "functionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a function with the given name from the specified project. If the given function is used by
                /// some trigger, the trigger will be updated to remove this function.
                /// </summary>
                /// <param name="name">Required. The name of the function which should be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a function with the given name from the specified project. If the given function is used by
                /// some trigger, the trigger will be updated to remove this function.
                /// </summary>
                public class DeleteRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the function which should be deleted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/functions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns a signed URL for downloading deployed function source code. The URL is only valid for a
                /// limited period and should be used within 30 minutes of generation. For more information about the
                /// signed URL usage see: https://cloud.google.com/storage/docs/access-control/signed-urls
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of function for which source code Google Cloud Storage signed URL should be
                /// generated.
                /// </param>
                public virtual GenerateDownloadUrlRequest GenerateDownloadUrl(Google.Apis.CloudFunctions.v2alpha.Data.GenerateDownloadUrlRequest body, string name)
                {
                    return new GenerateDownloadUrlRequest(service, body, name);
                }

                /// <summary>
                /// Returns a signed URL for downloading deployed function source code. The URL is only valid for a
                /// limited period and should be used within 30 minutes of generation. For more information about the
                /// signed URL usage see: https://cloud.google.com/storage/docs/access-control/signed-urls
                /// </summary>
                public class GenerateDownloadUrlRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.GenerateDownloadUrlResponse>
                {
                    /// <summary>Constructs a new GenerateDownloadUrl request.</summary>
                    public GenerateDownloadUrlRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFunctions.v2alpha.Data.GenerateDownloadUrlRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of function for which source code Google Cloud Storage signed URL should be
                    /// generated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFunctions.v2alpha.Data.GenerateDownloadUrlRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generateDownloadUrl";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}:generateDownloadUrl";

                    /// <summary>Initializes GenerateDownloadUrl parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/functions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns a signed URL for uploading a function source code. For more information about the signed URL
                /// usage see: https://cloud.google.com/storage/docs/access-control/signed-urls. Once the function
                /// source code upload is complete, the used signed URL should be provided in CreateFunction or
                /// UpdateFunction request as a reference to the function source code. When uploading source code to the
                /// generated signed URL, please follow these restrictions: * Source file type should be a zip file. *
                /// No credentials should be attached - the signed URLs provide access to the target bucket using
                /// internal service identity; if credentials were attached, the identity from the credentials would be
                /// used, but that identity does not have permissions to upload files to the URL. When making a HTTP PUT
                /// request, these two headers need to be specified: * `content-type: application/zip` And this header
                /// SHOULD NOT be specified: * `Authorization: Bearer YOUR_TOKEN`
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The project and location in which the Google Cloud Storage signed URL should be generated,
                /// specified in the format `projects/*/locations/*`.
                /// </param>
                public virtual GenerateUploadUrlRequest GenerateUploadUrl(Google.Apis.CloudFunctions.v2alpha.Data.GenerateUploadUrlRequest body, string parent)
                {
                    return new GenerateUploadUrlRequest(service, body, parent);
                }

                /// <summary>
                /// Returns a signed URL for uploading a function source code. For more information about the signed URL
                /// usage see: https://cloud.google.com/storage/docs/access-control/signed-urls. Once the function
                /// source code upload is complete, the used signed URL should be provided in CreateFunction or
                /// UpdateFunction request as a reference to the function source code. When uploading source code to the
                /// generated signed URL, please follow these restrictions: * Source file type should be a zip file. *
                /// No credentials should be attached - the signed URLs provide access to the target bucket using
                /// internal service identity; if credentials were attached, the identity from the credentials would be
                /// used, but that identity does not have permissions to upload files to the URL. When making a HTTP PUT
                /// request, these two headers need to be specified: * `content-type: application/zip` And this header
                /// SHOULD NOT be specified: * `Authorization: Bearer YOUR_TOKEN`
                /// </summary>
                public class GenerateUploadUrlRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.GenerateUploadUrlResponse>
                {
                    /// <summary>Constructs a new GenerateUploadUrl request.</summary>
                    public GenerateUploadUrlRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFunctions.v2alpha.Data.GenerateUploadUrlRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location in which the Google Cloud Storage signed URL should be
                    /// generated, specified in the format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFunctions.v2alpha.Data.GenerateUploadUrlRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generateUploadUrl";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+parent}/functions:generateUploadUrl";

                    /// <summary>Initializes GenerateUploadUrl parameter list.</summary>
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

                /// <summary>Returns a function with the given name from the requested project.</summary>
                /// <param name="name">Required. The name of the function which details should be obtained.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns a function with the given name from the requested project.</summary>
                public class GetRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.Function>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the function which details should be obtained.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/functions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+resource}:getIamPolicy";

                    /// <summary>Initializes GetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/functions/[^/]+$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Returns a list of functions that belong to the requested project.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the function should be listed, specified in the format
                /// `projects/*/locations/*` If you want to list functions in all locations, use "-" in place of a
                /// location. When listing functions in all locations, if one or more location(s) are unreachable, the
                /// response will contain functions from all reachable locations along with the names of any unreachable
                /// locations.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Returns a list of functions that belong to the requested project.</summary>
                public class ListRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.ListFunctionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the function should be listed, specified in the
                    /// format `projects/*/locations/*` If you want to list functions in all locations, use "-" in place
                    /// of a location. When listing functions in all locations, if one or more location(s) are
                    /// unreachable, the response will contain functions from all reachable locations along with the
                    /// names of any unreachable locations.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The filter for Functions that match the filter expression, following the syntax outlined in
                    /// https://google.aip.dev/160.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The sorting order of the resources returned. Value should be a comma separated list of fields.
                    /// The default sorting oder is ascending. See https://google.aip.dev/132#ordering.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Maximum number of functions to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListFunctionsResponse`; indicates that this is a continuation of
                    /// a prior `ListFunctions` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+parent}/functions";

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

                /// <summary>Updates existing function.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// A user-defined name of the function. Function names must be unique globally and match pattern
                /// `projects/*/locations/*/functions/*`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudFunctions.v2alpha.Data.Function body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates existing function.</summary>
                public class PatchRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFunctions.v2alpha.Data.Function body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// A user-defined name of the function. Function names must be unique globally and match pattern
                    /// `projects/*/locations/*/functions/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The list of fields to be updated. If no field mask is provided, all provided fields in the
                    /// request will be updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFunctions.v2alpha.Data.Function Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/functions/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudFunctions.v2alpha.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFunctions.v2alpha.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFunctions.v2alpha.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+resource}:setIamPolicy";

                    /// <summary>Initializes SetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/functions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudFunctions.v2alpha.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFunctions.v2alpha.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFunctions.v2alpha.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/functions/[^/]+$",
                        });
                    }
                }
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
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.Operation>
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
                    public override string RestPath => "v2alpha/{+name}";

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
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">Must not be set.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.ListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Must not be set.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. A filter for matching the requested operations. The supported formats of *filter* are:
                    /// To query for a specific function: project:*,location:*,function:* To query for all of the latest
                    /// operations for a project: project:*,latest:true
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of records that should be returned. Requested page size cannot exceed 100. If
                    /// not set, the default page size is 100. Pagination is only supported when querying for a specific
                    /// function.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Token identifying which result to start with, which is returned by a previous list call.
                    /// Pagination is only supported when querying for a specific function.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}/operations";

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

            /// <summary>Gets the Runtimes resource.</summary>
            public virtual RuntimesResource Runtimes { get; }

            /// <summary>The "runtimes" collection of methods.</summary>
            public class RuntimesResource
            {
                private const string Resource = "runtimes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RuntimesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Returns a list of runtimes that are supported for the requested project.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the runtimes should be listed, specified in the format
                /// `projects/*/locations/*`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Returns a list of runtimes that are supported for the requested project.</summary>
                public class ListRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.ListRuntimesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the runtimes should be listed, specified in the
                    /// format `projects/*/locations/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The filter for Runtimes that match the filter expression, following the syntax outlined in
                    /// https://google.aip.dev/160.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+parent}/runtimes";

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
                    }
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : CloudFunctionsBaseServiceRequest<Google.Apis.CloudFunctions.v2alpha.Data.ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The resource that owns the locations collection, if applicable.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// `"displayName=tokyo"`, and is documented in more detail in [AIP-160](https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the `next_page_token` field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2alpha/{+name}/locations";

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
    }
}
namespace Google.Apis.CloudFunctions.v2alpha.Data
{
    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs. If
    /// there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
    /// "allServices", "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ]
    /// }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ] }, { "service": "sampleservice.googleapis.com",
    /// "audit_log_configs": [ { "log_type": "DATA_READ" }, { "log_type": "DATA_WRITE", "exempted_members": [
    /// "user:aliya@example.com" ] } ] } ] } For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ
    /// logging. It also exempts jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.
    /// </summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

        /// <summary>
        /// Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ { "log_type":
    /// "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] } This enables
    /// 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ logging.
    /// </summary>
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the principals requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the Build step of the function that builds a container from the given source.</summary>
    public class BuildConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The Cloud Build name of the latest successful deployment of the function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual string Build { get; set; }

        /// <summary>
        /// Optional. User managed repository created in Artifact Registry optionally with a customer managed encryption
        /// key. This is the repository to which the function docker image will be pushed after it is built by Cloud
        /// Build. If unspecified, GCF will create and use a repository named 'gcf-artifacts' for every deployed region.
        /// It must match the pattern `projects/{project}/locations/{location}/repositories/{repository}`. Cross-project
        /// repositories are not supported. Cross-location repositories are not supported. Repository format must be
        /// 'DOCKER'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerRepository")]
        public virtual string DockerRepository { get; set; }

        /// <summary>
        /// The name of the function (as defined in source code) that will be executed. Defaults to the resource name
        /// suffix, if not specified. For backward compatibility, if function with given name is not found, then the
        /// system will try to use function named "function". For Node.js this is name of a function exported by the
        /// module specified in `source_location`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryPoint")]
        public virtual string EntryPoint { get; set; }

        /// <summary>User-provided build-time environment variables for the function</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// The runtime in which to run the function. Required when deploying a new function, optional when updating an
        /// existing function. For a complete list of possible choices, see the [`gcloud` command
        /// reference](https://cloud.google.com/sdk/gcloud/reference/functions/deploy#--runtime).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtime")]
        public virtual string Runtime { get; set; }

        /// <summary>The location of the function source code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>Output only. A permanent fixed identifier for source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenance")]
        public virtual SourceProvenance SourceProvenance { get; set; }

        /// <summary>
        /// Name of the Cloud Build Custom Worker Pool that should be used to build the function. The format of this
        /// field is `projects/{project}/locations/{region}/workerPools/{workerPool}` where {project} and {region} are
        /// the project id and region respectively where the worker pool is defined and {workerPool} is the short name
        /// of the worker pool. If the project id is not the same as the function, then the Cloud Functions Service
        /// Agent (service-@gcf-admin-robot.iam.gserviceaccount.com) must be granted the role Cloud Build Custom Workers
        /// Builder (roles/cloudbuild.customworkers.builder) in the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filters events based on exact matches on the CloudEvents attributes.</summary>
    public class EventFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of a CloudEvents attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; }

        /// <summary>
        /// Optional. The operator used for matching the events with the value of the filter. If not specified, only
        /// events that have an exact key-value pair specified in the filter are matched. The only allowed value is
        /// `match-path-pattern`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>Required. The value for the attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes EventTrigger, used to request events to be sent from another service.</summary>
    public class EventTrigger : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Criteria used to filter events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventFilters")]
        public virtual System.Collections.Generic.IList<EventFilter> EventFilters { get; set; }

        /// <summary>
        /// Required. The type of event to observe. For example: `google.cloud.audit.log.v1.written` or
        /// `google.cloud.pubsub.topic.v1.messagePublished`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>
        /// Optional. The name of a Pub/Sub topic in the same project that will be used as the transport topic for the
        /// event delivery. Format: `projects/{project}/topics/{topic}`. This is only valid for events of type
        /// `google.cloud.pubsub.topic.v1.messagePublished`. The topic provided here will not be deleted at function
        /// deletion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>Optional. If unset, then defaults to ignoring failures (i.e. not retrying them).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryPolicy")]
        public virtual string RetryPolicy { get; set; }

        /// <summary>
        /// Optional. The email of the trigger's service account. The service account must have permission to invoke
        /// Cloud Run services, the permission is `run.routes.invoke`. If empty, defaults to the Compute Engine default
        /// service account: `{project_number}-compute@developer.gserviceaccount.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Output only. The resource name of the Eventarc trigger. The format of this field is
        /// `projects/{project}/locations/{region}/triggers/{trigger}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual string Trigger { get; set; }

        /// <summary>
        /// The region that the trigger will be in. The trigger will only receive events originating in this region. It
        /// can be the same region as the function, a different region or multi-region, or the global region. If not
        /// provided, defaults to the same region as the function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerRegion")]
        public virtual string TriggerRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example
    /// (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() &amp;lt; 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' &amp;amp;&amp;amp; document.type != 'internal'" Example (Data
    /// Manipulation): title: "Notification string" description: "Create a notification string with a timestamp."
    /// expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that
    /// may be referenced within an expression are determined by the service that evaluates it. See the service
    /// documentation for additional information.
    /// </summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs
        /// which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a Cloud Function that contains user computation executed in response to an event. It encapsulate
    /// function and triggers configurations.
    /// </summary>
    public class Function : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes the Build step of the function that builds a container from the given source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildConfig")]
        public virtual BuildConfig BuildConfig { get; set; }

        /// <summary>User-provided description of a function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Describe whether the function is gen1 or gen2.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual string Environment { get; set; }

        /// <summary>
        /// An Eventarc trigger managed by Google Cloud Functions that fires events in response to a condition in
        /// another service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTrigger")]
        public virtual EventTrigger EventTrigger { get; set; }

        /// <summary>Labels associated with this Cloud Function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// A user-defined name of the function. Function names must be unique globally and match pattern
        /// `projects/*/locations/*/functions/*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Describes the Service being deployed. Currently deploys services to Cloud Run (fully managed).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceConfig")]
        public virtual ServiceConfig ServiceConfig { get; set; }

        /// <summary>Output only. State of the function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. State Messages for this Cloud Function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessages")]
        public virtual System.Collections.Generic.IList<GoogleCloudFunctionsV2alphaStateMessage> StateMessages { get; set; }

        /// <summary>Output only. The last update timestamp of a Cloud Function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request of `GenerateDownloadUrl` method.</summary>
    public class GenerateDownloadUrlRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of `GenerateDownloadUrl` method.</summary>
    public class GenerateDownloadUrlResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The generated Google Cloud Storage signed URL that should be used for function source code download.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadUrl")]
        public virtual string DownloadUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request of `GenerateSourceUploadUrl` method.</summary>
    public class GenerateUploadUrlRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of `GenerateSourceUploadUrl` method.</summary>
    public class GenerateUploadUrlResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location of the source code in the upload bucket. Once the archive is uploaded using the `upload_url`
        /// use this field to set the `function.build_config.source.storage_source` during CreateFunction and
        /// UpdateFunction. Generation defaults to 0, as Cloud Storage provides a new generation only upon uploading a
        /// new object or version of an object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSource")]
        public virtual StorageSource StorageSource { get; set; }

        /// <summary>
        /// The generated Google Cloud Storage signed URL that should be used for a function source code upload. The
        /// uploaded file should be a zip archive which contains a function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadUrl")]
        public virtual string UploadUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudFunctionsV2alphaOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Identifies whether the user has requested cancellation of the operation. Operations that have successfully
        /// been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

        /// <summary>The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The original request that started the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestResource")]
        public virtual System.Collections.Generic.IDictionary<string, object> RequestResource { get; set; }

        /// <summary>Mechanism for reporting in-progress stages</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stages")]
        public virtual System.Collections.Generic.IList<GoogleCloudFunctionsV2alphaStage> Stages { get; set; }

        /// <summary>Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Each Stage of the deployment process</summary>
    public class GoogleCloudFunctionsV2alphaStage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Message describing the Stage</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Name of the Stage. This will be unique for each Stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Resource of the Stage</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>Link to the current Stage resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>Current state of the Stage</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>State messages from the current Stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessages")]
        public virtual System.Collections.Generic.IList<GoogleCloudFunctionsV2alphaStateMessage> StateMessages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Informational messages about the state of the Cloud Function or Operation.</summary>
    public class GoogleCloudFunctionsV2alphaStateMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Severity of the state message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>One-word CamelCase type of the state message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudFunctionsV2betaOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Identifies whether the user has requested cancellation of the operation. Operations that have successfully
        /// been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

        /// <summary>The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The original request that started the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestResource")]
        public virtual System.Collections.Generic.IDictionary<string, object> RequestResource { get; set; }

        /// <summary>Mechanism for reporting in-progress stages</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stages")]
        public virtual System.Collections.Generic.IList<GoogleCloudFunctionsV2betaStage> Stages { get; set; }

        /// <summary>Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Each Stage of the deployment process</summary>
    public class GoogleCloudFunctionsV2betaStage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Message describing the Stage</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Name of the Stage. This will be unique for each Stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Resource of the Stage</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>Link to the current Stage resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>Current state of the Stage</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>State messages from the current Stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessages")]
        public virtual System.Collections.Generic.IList<GoogleCloudFunctionsV2betaStateMessage> StateMessages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Informational messages about the state of the Cloud Function or Operation.</summary>
    public class GoogleCloudFunctionsV2betaStateMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Severity of the state message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>One-word CamelCase type of the state message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListFunctions` method.</summary>
    public class ListFunctionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The functions that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functions")]
        public virtual System.Collections.Generic.IList<Function> Functions { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Locations that could not be reached. The response does not include any functions from these locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>Response for the `ListRuntimes` method.</summary>
    public class ListRuntimesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The runtimes that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimes")]
        public virtual System.Collections.Generic.IList<Runtime> Runtimes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The friendly name for this location, typically a nearby city name. For example, "Tokyo".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Cross-service attributes for the location. For example {"cloud.googleapis.com/region": "us-east1"}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The canonical id for this location. For example: `"us-east1"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Service-specific metadata. For example the available capacity at the given location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Resource name for the location, which may vary between implementations. For example:
        /// `"projects/example-project/locations/us-east1"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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

    /// <summary>Metadata describing an Operation</summary>
    public class OperationMetadataV1 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud Build ID of the function created or updated by an API call. This field is only populated for
        /// Create and Update operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildId")]
        public virtual string BuildId { get; set; }

        /// <summary>
        /// The Cloud Build Name of the function deployment. This field is only populated for Create and Update
        /// operations. `projects//locations//builds/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildName")]
        public virtual string BuildName { get; set; }

        /// <summary>The original request that started the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual System.Collections.Generic.IDictionary<string, object> Request { get; set; }

        /// <summary>
        /// An identifier for Firebase function sources. Disclaimer: This field is only supported for Firebase function
        /// deployments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceToken")]
        public virtual string SourceToken { get; set; }

        /// <summary>
        /// Target of the operation - for example `projects/project-1/locations/region-1/functions/function-1`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Type of operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The last update timestamp of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Version id of the function created or updated by an API call. This field is only populated for Create and
        /// Update operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionId")]
        public virtual System.Nullable<long> VersionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members`, or principals, to a single
    /// `role`. Principals can be user accounts, service accounts, Google groups, and domains (such as G Suite). A
    /// `role` is a named list of permissions; each `role` can be an IAM predefined role or a user-created custom role.
    /// For some types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical
    /// expression that allows access to a resource only if the expression evaluates to `true`. A condition can add
    /// constraints based on attributes of the request, the resource, or both. To learn which resources support
    /// conditions in their IAM policies, see the [IAM
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** { "bindings":
    /// [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3 For a description of IAM and its features,
    /// see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an invalid
        /// value are rejected. Any operation that affects conditional role bindings must specify version `3`. This
        /// requirement applies to the following operations: * Getting a policy that includes a conditional role binding
        /// * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy * Removing
        /// any role binding, with or without a condition, from a policy that includes conditions **Important:** If you
        /// use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit this
        /// field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost. If a policy does not include any conditions, operations on
        /// that policy may specify any valid version or leave the field unset. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>Location of the source in a Google Cloud Source Repository.</summary>
    public class RepoSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Regex matching branches to build. The syntax of the regular expressions accepted is the syntax accepted by
        /// RE2 and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branchName")]
        public virtual string BranchName { get; set; }

        /// <summary>Explicit commit SHA to build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitSha")]
        public virtual string CommitSha { get; set; }

        /// <summary>
        /// Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's
        /// `dir` is specified and is an absolute path, this value is ignored for that step's execution. eg. helloworld
        /// (no leading slash allowed)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invertRegex")]
        public virtual System.Nullable<bool> InvertRegex { get; set; }

        /// <summary>
        /// ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the build is
        /// assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Name of the Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoName")]
        public virtual string RepoName { get; set; }

        /// <summary>
        /// Regex matching tags to build. The syntax of the regular expressions accepted is the syntax accepted by RE2
        /// and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagName")]
        public virtual string TagName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a runtime and any special information (e.g., deprecation status) related to it.</summary>
    public class Runtime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user facing name, eg 'Go 1.13', 'Node.js 12', etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The environment for the runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual string Environment { get; set; }

        /// <summary>The name of the runtime, e.g., 'go113', 'nodejs12', etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The stage of life this runtime is in, e.g., BETA, GA, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stage")]
        public virtual string Stage { get; set; }

        /// <summary>Warning messages, e.g., a deprecation warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<string> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for a secret environment variable. It has the information necessary to fetch the secret value from
    /// secret manager and expose it as an environment variable.
    /// </summary>
    public class SecretEnvVar : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Project identifier (preferably project number but can also be the project ID) of the project that contains
        /// the secret. If not set, it will be populated with the function's project assuming that the secret exists in
        /// the same project as of the function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Name of the secret in secret manager (not the full resource name).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual string Secret { get; set; }

        /// <summary>
        /// Version of the secret (version number or the string 'latest'). It is recommended to use a numeric version
        /// for secret environment variables as any updates to the secret value is not reflected until new instances
        /// start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the Service being deployed. Currently Supported : Cloud Run (fully managed).</summary>
    public class ServiceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether 100% of traffic is routed to the latest revision. On CreateFunction and UpdateFunction, when set to
        /// true, the revision being deployed will serve 100% of traffic, ignoring any traffic split settings, if any.
        /// On GetFunction, true will be returned if the latest revision is serving 100% of traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allTrafficOnLatestRevision")]
        public virtual System.Nullable<bool> AllTrafficOnLatestRevision { get; set; }

        /// <summary>
        /// The amount of memory available for a function. Defaults to 256M. Supported units are k, M, G, Mi, Gi. If no
        /// unit is supplied the value is interpreted as bytes. See
        /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
        /// a full description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableMemory")]
        public virtual string AvailableMemory { get; set; }

        /// <summary>Environment variables that shall be available during function execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>The ingress settings for the function, controlling what traffic can reach it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressSettings")]
        public virtual string IngressSettings { get; set; }

        /// <summary>
        /// The limit on the maximum number of function instances that may coexist at a given time. In some cases, such
        /// as rapid traffic surges, Cloud Functions may, for a short period of time, create more instances than the
        /// specified max instances limit. If your function cannot tolerate this temporary behavior, you may want to
        /// factor in a safety margin and set a lower max instances value than your function can tolerate. See the [Max
        /// Instances](https://cloud.google.com/functions/docs/max-instances) Guide for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstanceCount")]
        public virtual System.Nullable<int> MaxInstanceCount { get; set; }

        /// <summary>
        /// The limit on the minimum number of function instances that may coexist at a given time. Function instances
        /// are kept in idle state for a short period after they finished executing the request to reduce cold start
        /// time for subsequent requests. Setting a minimum instance count will ensure that the given number of
        /// instances are kept running in idle state always. This can help with cold start times when jump in incoming
        /// request count occurs after the idle instance would have been stopped in the default case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minInstanceCount")]
        public virtual System.Nullable<int> MinInstanceCount { get; set; }

        /// <summary>Output only. The name of service revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>Secret environment variables configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnvironmentVariables")]
        public virtual System.Collections.Generic.IList<SecretEnvVar> SecretEnvironmentVariables { get; set; }

        /// <summary>
        /// Output only. Name of the service associated with a Function. The format of this field is
        /// `projects/{project}/locations/{region}/services/{service}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// The email of the service's service account. If empty, defaults to
        /// `{project_number}-compute@developer.gserviceaccount.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>
        /// The function execution timeout. Execution is considered failed and can be terminated if the function is not
        /// completed at the end of the timeout period. Defaults to 60 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutSeconds")]
        public virtual System.Nullable<int> TimeoutSeconds { get; set; }

        /// <summary>Output only. URI of the Service deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// The Serverless VPC Access connector that this cloud function can connect to. The format of this field is
        /// `projects/*/locations/*/connectors/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcConnector")]
        public virtual string VpcConnector { get; set; }

        /// <summary>The egress settings for the connector, controlling what traffic is diverted through it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcConnectorEgressSettings")]
        public virtual string VpcConnectorEgressSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The location of the function source code.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If provided, get the source from this location in a Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoSource")]
        public virtual RepoSource RepoSource { get; set; }

        /// <summary>If provided, get the source from this location in Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSource")]
        public virtual StorageSource StorageSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provenance of the source. Ways to find the original source, or verify that some source was used for this build.
    /// </summary>
    public class SourceProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A copy of the build's `source.repo_source`, if exists, with any revisions resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedRepoSource")]
        public virtual RepoSource ResolvedRepoSource { get; set; }

        /// <summary>A copy of the build's `source.storage_source`, if exists, with any generations resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedStorageSource")]
        public virtual StorageSource ResolvedStorageSource { get; set; }

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

    /// <summary>Location of the source in an archive file in Google Cloud Storage.</summary>
    public class StorageSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage bucket containing the source (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Google Cloud Storage generation for the object. If the generation is omitted, the latest generation will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Google Cloud Storage object containing the source. This object must be a gzipped archive file (`.tar.gz`)
        /// containing source to build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
