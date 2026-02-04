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

namespace Google.Apis.CCAIPlatform.v1alpha1
{
    /// <summary>The CCAIPlatform Service.</summary>
    public class CCAIPlatformService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CCAIPlatformService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CCAIPlatformService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://contactcenteraiplatform.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://contactcenteraiplatform.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "contactcenteraiplatform";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Contact Center AI Platform API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Contact Center AI Platform API.</summary>
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

    /// <summary>A base abstract class for CCAIPlatform requests.</summary>
    public abstract class CCAIPlatformBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CCAIPlatformBaseServiceRequest instance.</summary>
        protected CCAIPlatformBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CCAIPlatform parameter list.</summary>
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
                ContactCenters = new ContactCentersResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the ContactCenters resource.</summary>
            public virtual ContactCentersResource ContactCenters { get; }

            /// <summary>The "contactCenters" collection of methods.</summary>
            public class ContactCentersResource
            {
                private const string Resource = "contactCenters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ContactCentersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new ContactCenter in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.CCAIPlatform.v1alpha1.Data.ContactCenter body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new ContactCenter in a given project and location.</summary>
                public class CreateRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CCAIPlatform.v1alpha1.Data.ContactCenter body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Id of the requesting object If auto-generating Id server-side, remove this field and
                    /// contact_center_id from the method_signature of Create RPC
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("contactCenterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ContactCenterId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CCAIPlatform.v1alpha1.Data.ContactCenter Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+parent}/contactCenters";

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
                        RequestParameters.Add("contactCenterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "contactCenterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single ContactCenter.</summary>
                /// <param name="name">Required. Name of the resource</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single ContactCenter.</summary>
                public class DeleteRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/contactCenters/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single ContactCenter.</summary>
                /// <param name="name">Required. Name of the resource</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single ContactCenter.</summary>
                public class GetRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.ContactCenter>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/contactCenters/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists ContactCenters in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for ListContactCentersRequest</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists ContactCenters in a given project and location.</summary>
                public class ListRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.ListContactCentersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListContactCentersRequest</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filtering results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Hint for how to order the results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, server will
                    /// pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+parent}/contactCenters";

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

                /// <summary>Updates the parameters of a single ContactCenter.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">name of resource</param>
                public virtual PatchRequest Patch(Google.Apis.CCAIPlatform.v1alpha1.Data.ContactCenter body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single ContactCenter.</summary>
                public class PatchRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CCAIPlatform.v1alpha1.Data.ContactCenter body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>name of resource</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the ContactCenter
                    /// resource by the update. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CCAIPlatform.v1alpha1.Data.ContactCenter Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/contactCenters/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.CCAIPlatform.v1alpha1.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(this.service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CCAIPlatform.v1alpha1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CCAIPlatform.v1alpha1.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}:cancel";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.Empty>
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
                    public override string RestPath => "v1alpha1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
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
                public class GetRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.Operation>
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
                    public override string RestPath => "v1alpha1/{+name}";

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
                public class ListRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.ListOperationsResponse>
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

                    /// <summary>
                    /// When set to `true`, operations that are reachable are returned as normal, and those that are
                    /// unreachable are returned in the ListOperationsResponse.unreachable field. This can only be
                    /// `true` when reading across collections. For example, when `parent` is set to
                    /// `"projects/example/locations/-"`. This field is not supported by default and will result in an
                    /// `UNIMPLEMENTED` error if set unless explicitly documented otherwise in service or product
                    /// specific documentation.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}/operations";

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

            /// <summary>Generates shifts constrained by various parameters.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Name of the parent resource associated with the request. Format:
            /// projects/{project}/locations/{location}
            /// </param>
            public virtual GenerateShiftsRequest GenerateShifts(Google.Apis.CCAIPlatform.v1alpha1.Data.GenerateShiftsRequest body, string parent)
            {
                return new GenerateShiftsRequest(this.service, body, parent);
            }

            /// <summary>Generates shifts constrained by various parameters.</summary>
            public class GenerateShiftsRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.Operation>
            {
                /// <summary>Constructs a new GenerateShifts request.</summary>
                public GenerateShiftsRequest(Google.Apis.Services.IClientService service, Google.Apis.CCAIPlatform.v1alpha1.Data.GenerateShiftsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the parent resource associated with the request. Format:
                /// projects/{project}/locations/{location}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CCAIPlatform.v1alpha1.Data.GenerateShiftsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generateShifts";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+parent}:generateShifts";

                /// <summary>Initializes GenerateShifts parameter list.</summary>
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.Location>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Resource name for the location.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists information about the supported locations for this service. This method can be called in two ways:
            /// * **List all public locations:** Use the path `GET /v1/locations`. * **List project-visible locations:**
            /// Use the path `GET /v1/projects/{project_id}/locations`. This may include public locations as well as
            /// private or other locations specifically visible to the project.
            /// </summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// Lists information about the supported locations for this service. This method can be called in two ways:
            /// * **List all public locations:** Use the path `GET /v1/locations`. * **List project-visible locations:**
            /// Use the path `GET /v1/projects/{project_id}/locations`. This may include public locations as well as
            /// private or other locations specifically visible to the project.
            /// </summary>
            public class ListRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.ListLocationsResponse>
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
                /// Optional. Do not use this field. It is unsupported and is ignored unless explicitly documented
                /// otherwise. This is primarily for internal usage.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("extraLocationTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ExtraLocationTypes { get; set; }

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
                public override string RestPath => "v1alpha1/{+name}/locations";

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
                    RequestParameters.Add("extraLocationTypes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "extraLocationTypes",
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

            /// <summary>
            /// Queries the contact center quota, an aggregation over all the projects, that belongs to the billing
            /// account, which the input project belongs to.
            /// </summary>
            /// <param name="parent">Required. Parent project resource id.</param>
            public virtual QueryContactCenterQuotaRequest QueryContactCenterQuota(string parent)
            {
                return new QueryContactCenterQuotaRequest(this.service, parent);
            }

            /// <summary>
            /// Queries the contact center quota, an aggregation over all the projects, that belongs to the billing
            /// account, which the input project belongs to.
            /// </summary>
            public class QueryContactCenterQuotaRequest : CCAIPlatformBaseServiceRequest<Google.Apis.CCAIPlatform.v1alpha1.Data.ContactCenterQuota>
            {
                /// <summary>Constructs a new QueryContactCenterQuota request.</summary>
                public QueryContactCenterQuotaRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Parent project resource id.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "queryContactCenterQuota";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+parent}:queryContactCenterQuota";

                /// <summary>Initializes QueryContactCenterQuota parameter list.</summary>
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
}
namespace Google.Apis.CCAIPlatform.v1alpha1.Data
{
    /// <summary>Message storing info about the first admin user. Next ID: 3</summary>
    public class AdminUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Last/family name of the first admin user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>Optional. First/given name of the first admin user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a logical CCAIP component that e.g. “EMAIL”, "CRM". For more information see go/ccaip-private-path-v2.
    /// Each logical component is associated with a list of service attachments.
    /// </summary>
    public class Component : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Associated service attachments. The service attachment names that will be used for sending private traffic
        /// to the CCAIP tenant project. Example service attachment name:
        /// "projects/${TENANT_PROJECT_ID}/regions/${REGION}/serviceAttachments/ingress-default".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAttachmentNames")]
        public virtual System.Collections.Generic.IList<string> ServiceAttachmentNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing ContactCenter object</summary>
    public class ContactCenter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Info about the first admin user, such as given name and family name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminUser")]
        public virtual AdminUser AdminUser { get; set; }

        /// <summary>Optional. Whether the advanced reporting feature is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advancedReportingEnabled")]
        public virtual System.Nullable<bool> AdvancedReportingEnabled { get; set; }

        /// <summary>
        /// Optional. Whether to enable users to be created in the CCAIP-instance concurrently to having users in Cloud
        /// identity
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ccaipManagedUsers")]
        public virtual System.Nullable<bool> CcaipManagedUsers { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. [Output only] Create time stamp</summary>
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

        /// <summary>Optional. Critical release channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("critical")]
        public virtual Critical Critical { get; set; }

        /// <summary>
        /// Required. Immutable. At least 2 and max 16 char long, must conform to [RFC
        /// 1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerDomainPrefix")]
        public virtual string CustomerDomainPrefix { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. Timestamp in UTC of when this resource was soft-deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. A user friendly name for the ContactCenter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Early release channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("early")]
        public virtual Early Early { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Output only. Timestamp in UTC of when this resource is considered expired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Feature configuration to populate the feature flags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureConfig")]
        public virtual FeatureConfig FeatureConfig { get; set; }

        /// <summary>The configuration of this instance, it is currently immutable once created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceConfig")]
        public virtual InstanceConfig InstanceConfig { get; set; }

        /// <summary>Immutable. The KMS key name to encrypt the user input (`ContactCenter`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>name of resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Normal release channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normal")]
        public virtual Normal Normal { get; set; }

        /// <summary>Optional. VPC-SC related networking configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateAccess")]
        public virtual PrivateAccess PrivateAccess { get; set; }

        /// <summary>Output only. TODO(b/283407860) Deprecate this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateComponents")]
        public virtual System.Collections.Generic.IList<string> PrivateComponents { get; set; }

        private string _purgeTimeRaw;

        private object _purgeTime;

        /// <summary>Output only. Timestamp in UTC of when this resource is going to be hard-deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeTime")]
        public virtual string PurgeTimeRaw
        {
            get => _purgeTimeRaw;
            set
            {
                _purgeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _purgeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PurgeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PurgeTimeDateTimeOffset instead.")]
        public virtual object PurgeTime
        {
            get => _purgeTime;
            set
            {
                _purgeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _purgeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PurgeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PurgeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PurgeTimeRaw);
            set => PurgeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. UJET release version, unique for each new release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseVersion")]
        public virtual string ReleaseVersion { get; set; }

        /// <summary>Optional. Params that sets up Google as IdP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samlParams")]
        public virtual SAMLParams SamlParams { get; set; }

        /// <summary>Output only. The state of this contact center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. [Output only] Update time stamp</summary>
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

        /// <summary>Output only. URIs to access the deployed ContactCenters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual URIs Uris { get; set; }

        /// <summary>Optional. Email address of the first admin user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
        public virtual string UserEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a quota for contact centers.</summary>
    public class ContactCenterQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated: Use the Quota fields instead. Reflects the count limit of contact centers on a billing account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactCenterCountLimit")]
        public virtual System.Nullable<int> ContactCenterCountLimit { get; set; }

        /// <summary>
        /// Deprecated: Use the Quota fields instead. Reflects the count sum of contact centers on a billing account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactCenterCountSum")]
        public virtual System.Nullable<int> ContactCenterCountSum { get; set; }

        /// <summary>Quota details per contact center instance type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotas")]
        public virtual System.Collections.Generic.IList<Quota> Quotas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Instances in this Channel will receive updates after all instances in `Normal` were updated. They also will only
    /// be updated outside of their peak hours.
    /// </summary>
    public class Critical : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Hours during which the instance should not be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peakHours")]
        public virtual System.Collections.Generic.IList<WeeklySchedule> PeakHours { get; set; }

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

    /// <summary>List of dates.</summary>
    public class DateList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Values in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<Date> Values { get; set; }

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

    /// <summary>LINT.IfChange First Channel to receive the updates. Meant to dev/test instances</summary>
    public class Early : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a particular employee for planning purposes.</summary>
    public class EmployeeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Unique ID of this employee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. A list of unwanted event intervals for this employee. The start time of the interval must be in
        /// the planning horizon.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unwantedEventIntervals")]
        public virtual System.Collections.Generic.IList<UnwantedEventInterval> UnwantedEventIntervals { get; set; }

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

    /// <summary>
    /// Template specifying rules for generating a single event that occurs during a shift. An event may represent a
    /// meeting, break, lunch, etc.
    /// </summary>
    public class EventTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Fixed duration in minutes of this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationMinutes")]
        public virtual System.Nullable<int> DurationMinutes { get; set; }

        /// <summary>Required. Unique ID of this template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. Maximum number of minutes after the beginning of a shift that this event can start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumMinutesAfterShiftStart")]
        public virtual System.Nullable<int> MaximumMinutesAfterShiftStart { get; set; }

        /// <summary>
        /// Optional. Minimum number of minutes after the beginning of a shift that this event can start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumMinutesAfterShiftStart")]
        public virtual System.Nullable<int> MinimumMinutesAfterShiftStart { get; set; }

        /// <summary>
        /// Required. The time increment (in minutes) used to generate the set of possible event start times between
        /// `minimum_minutes_after_shift_start` and `maximum_minutes_after_shift_start`. For example, if the minimum
        /// minutes after shift start are 30, maximum minutes after shift start are 45, and the start time increment is
        /// 5 minutes, the event can take place 30, 35, 40, or 45 minutes after the start of the shift.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeIncrementMinutes")]
        public virtual System.Nullable<int> StartTimeIncrementMinutes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FeatureConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If true - enables the agent desktop feature. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentDesktopEnabled")]
        public virtual System.Nullable<bool> AgentDesktopEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request with constraints for generating shifts. The shifts generated must adhere to these constraints.
    /// </summary>
    public class GenerateShiftsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Employee information that should be considered when generating shifts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employeeInfo")]
        public virtual System.Collections.Generic.IList<EmployeeInfo> EmployeeInfo { get; set; }

        /// <summary>Required. The solver will generate the maximum number of shifts per shift template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("planningHorizon")]
        public virtual PlanningHorizon PlanningHorizon { get; set; }

        /// <summary>
        /// Required. Set of shift templates specifying rules for generating shifts. A shift template can be used for
        /// generating multiple shifts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shiftTemplates")]
        public virtual System.Collections.Generic.IList<ShiftTemplate> ShiftTemplates { get; set; }

        /// <summary>Required. Parameters for the solver.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solverConfig")]
        public virtual SolverConfig SolverConfig { get; set; }

        /// <summary>
        /// Required. All the workforce demands that the generated shifts need to cover. The planning horizon is defined
        /// between the earliest start time and the latest end time across all the entries. This field cannot be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workforceDemands")]
        public virtual WorkforceDemandList WorkforceDemands { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudCommonOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the operation was created.</summary>
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

        /// <summary>Output only. The time the operation finished running.</summary>
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

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message storing the instance configuration.</summary>
    public class InstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The instance size of this the instance configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceSize")]
        public virtual string InstanceSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing ContactCenters</summary>
    public class ListContactCentersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of ContactCenter</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactCenters")]
        public virtual System.Collections.Generic.IList<ContactCenter> ContactCenters { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
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

        /// <summary>
        /// Unordered list. Unreachable resources. Populated when the request sets
        /// `ListOperationsRequest.return_partial_success` and reads across collections. For example, when attempting to
        /// list all resources across all supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents a Google Cloud location.</summary>
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

    /// <summary>
    /// Instances in this Channel will receive updates after all instances in `Early` were updated + 2 days.
    /// </summary>
    public class Normal : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>Contact center information for this request</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactCenter")]
        public virtual ContactCenter ContactCenter { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the operation was created.</summary>
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

        /// <summary>Output only. The time the operation finished running.</summary>
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
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the time interval during which the solver should generate shifts. The start time must be before the
    /// end time.
    /// </summary>
    public class PlanningHorizon : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. End of the time interval for the given demand (exclusive). These values are read down to the
        /// minute; seconds and all smaller units are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual DateTime EndTime { get; set; }

        /// <summary>
        /// Required. Start of the time interval for the given demand (inclusive). These values are read down to the
        /// minute; seconds and all smaller units are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual DateTime StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines ingress and egress private traffic settings for CCAIP instances.</summary>
    public class PrivateAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of egress components that should not be accessed via the Internet. For more information see
        /// go/ccaip-private-path-v2.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressSettings")]
        public virtual System.Collections.Generic.IList<Component> EgressSettings { get; set; }

        /// <summary>
        /// List of ingress components that should not be accessed via the Internet. For more information see
        /// go/ccaip-private-path-v2.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressSettings")]
        public virtual System.Collections.Generic.IList<Component> IngressSettings { get; set; }

        /// <summary>Private service connect settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscSetting")]
        public virtual PscSetting PscSetting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Private service connect settings.</summary>
    public class PscSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of project ids that are allowed to send traffic to the service attachment. This field should be
        /// filled only for the ingress components.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedConsumerProjectIds")]
        public virtual System.Collections.Generic.IList<string> AllowedConsumerProjectIds { get; set; }

        /// <summary>Output only. The CCAIP tenant project ids.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerProjectIds")]
        public virtual System.Collections.Generic.IList<string> ProducerProjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Quota details.</summary>
    public class Quota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Reflects the count limit of contact centers on a billing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactCenterCountLimit")]
        public virtual System.Nullable<int> ContactCenterCountLimit { get; set; }

        /// <summary>Reflects the count sum of contact centers on a billing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactCenterCountSum")]
        public virtual System.Nullable<int> ContactCenterCountSum { get; set; }

        /// <summary>Contact center instance type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactCenterInstanceSize")]
        public virtual string ContactCenterInstanceSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message storing SAML params to enable Google as IDP.</summary>
    public class SAMLParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional contexts used for authentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationContexts")]
        public virtual System.Collections.Generic.IList<string> AuthenticationContexts { get; set; }

        /// <summary>SAML certificate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificate")]
        public virtual string Certificate { get; set; }

        /// <summary>IdP field that maps to the user’s email address</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailMapping")]
        public virtual string EmailMapping { get; set; }

        /// <summary>Entity id URL</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>Single sign-on URL</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssoUri")]
        public virtual string SsoUri { get; set; }

        /// <summary>Email address of the first admin users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
        public virtual string UserEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Template specifying rules for generating shifts. A shift is a unit of work that specifies a start time, end
    /// time, and may contain events (e.g. lunch, breaks etc.). Shifts will be assigned to specific dates in the
    /// response.
    /// </summary>
    public class ShiftTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of specific employee IDs that can be assigned to shifts generated by this template. If this
        /// field is present, there will be `EmployeeSchedule`s in the response for which the
        /// `EmployeeSchedule.employee_id` field is set to one of the IDs in this list. The number of employee schedules
        /// with an assigned employee ID will be between `minimum_employee_count` and `maximum_employee_count`. If this
        /// field is empty, between `minimum_employee_count` and `maximum_employee_count` employees can be assigned to
        /// shifts generated by this template and the employee schedules won't have an assigned employee ID. Currently,
        /// only one assignable employee ID is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignableEmployeeIds")]
        public virtual System.Collections.Generic.IList<string> AssignableEmployeeIds { get; set; }

        /// <summary>
        /// Optional. Fixed number of days off per week. An employee has a given day off if they are not assigned to a
        /// shift that starts on that day. A week is 7 days and begins on Sunday.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysOffCountPerWeek")]
        public virtual System.Nullable<int> DaysOffCountPerWeek { get; set; }

        /// <summary>Optional. Fixed dates when shifts from this template should not be generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysOffDates")]
        public virtual DateList DaysOffDates { get; set; }

        /// <summary>Required. Fixed duration of a shift generated by this template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationMinutes")]
        public virtual System.Nullable<int> DurationMinutes { get; set; }

        /// <summary>
        /// Required. Earliest time in the day that a shift can start. This value is specified with hours and minutes;
        /// seconds and nanos are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earliestStartTime")]
        public virtual TimeOfDay EarliestStartTime { get; set; }

        /// <summary>
        /// Optional. Rules for generating events for each shift. Exactly one event will be included in each shift for
        /// each `EventTemplate` specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTemplates")]
        public virtual System.Collections.Generic.IList<EventTemplate> EventTemplates { get; set; }

        /// <summary>Required. Unique ID of this template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. Latest time in the day that a shift can start. This value is specified with hours and minutes;
        /// seconds and nanos are ignored. If this value is less than the `earliest_start_time`, it may imply an
        /// overnight shift.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestStartTime")]
        public virtual TimeOfDay LatestStartTime { get; set; }

        /// <summary>
        /// Required. Maximum number of employees that can be assigned to all shifts generated by this template on
        /// working days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumEmployeeCount")]
        public virtual System.Nullable<int> MaximumEmployeeCount { get; set; }

        /// <summary>
        /// Optional. Minimum number of employees that can be assigned to all shifts generated by this template on
        /// working days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumEmployeeCount")]
        public virtual System.Nullable<int> MinimumEmployeeCount { get; set; }

        /// <summary>Optional. Minimum minutes between the end of one event and the start of the next.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumIntereventGapMinutes")]
        public virtual System.Nullable<int> MinimumIntereventGapMinutes { get; set; }

        /// <summary>
        /// Optional. The time increment (in minutes) used to generate the set of possible start times between
        /// `earliest_start_time` and `latest_start_time`. For example, if the earliest start time is 8:00, the latest
        /// start time is 8:30, and the start time increment is 10 minutes, then all possible start times for this shift
        /// template are: 8:00, 8:10, 8:20, and 8:30.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeIncrementMinutes")]
        public virtual System.Nullable<int> StartTimeIncrementMinutes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies additional parameters for the solver generating shifts.</summary>
    public class SolverConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Maximum time the solver should spend on the problem. If not set, defaults to 1 minute. The choice
        /// of a time limit should depend on the size of the problem. To give an example, when solving a 7-day instance
        /// with 2 `ShiftTemplates`, each with ~20 possible start times and holding 2 events with ~30 possible start
        /// times, and two days off per week, recommended values are: &amp;lt;10s for fast solutions (and likely
        /// suboptimal), (10s, 300s) for good quality solutions, and &amp;gt;300s for an exhaustive search. Larger
        /// instances may require longer time limits. This value is not a hard limit and it does not account for the
        /// communication overhead. The expected latency to solve the problem may slightly exceed this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumProcessingDuration")]
        public virtual object MaximumProcessingDuration { get; set; }

        /// <summary>Required. Specifies the type of schedule to generate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleType")]
        public virtual string ScheduleType { get; set; }

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

    /// <summary>Message storing the URIs of the ContactCenter.</summary>
    public class URIs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Chat Bot Uri of the ContactCenter</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatBotUri")]
        public virtual string ChatBotUri { get; set; }

        /// <summary>Media Uri of the ContactCenter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaUri")]
        public virtual string MediaUri { get; set; }

        /// <summary>Root Uri of the ContactCenter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootUri")]
        public virtual string RootUri { get; set; }

        /// <summary>Virtual Agent Streaming Service Uri of the ContactCenter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualAgentStreamingServiceUri")]
        public virtual string VirtualAgentStreamingServiceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies a time interval during which the overlap with events (generated from event templates) should be
    /// minimal.
    /// </summary>
    public class UnwantedEventInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Duration of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationMinutes")]
        public virtual System.Nullable<int> DurationMinutes { get; set; }

        /// <summary>Required. Start time of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual DateTime StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message representing a weekly schedule.</summary>
    public class WeeklySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Days of the week this schedule applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("days")]
        public virtual System.Collections.Generic.IList<string> Days { get; set; }

        /// <summary>Optional. Duration of the schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// Optional. Daily end time of the schedule. If `end_time` is before `start_time`, the schedule will be
        /// considered as ending on the next day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual TimeOfDay EndTime { get; set; }

        /// <summary>Required. Daily start time of the schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the number of employees required to cover the demand in the given time interval. The length of the
    /// interval must be strictly positive.
    /// </summary>
    public class WorkforceDemand : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Number of employees needed to cover the demand for this interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employeeCount")]
        public virtual System.Nullable<int> EmployeeCount { get; set; }

        /// <summary>
        /// Required. End of the time interval for the given demand (exclusive). These values are read down to the
        /// minute; seconds and all smaller units are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual DateTime EndTime { get; set; }

        /// <summary>
        /// Required. Start of the time interval for the given demand (inclusive). These values are read down to the
        /// minute; seconds and all smaller units are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual DateTime StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of workforce demands.</summary>
    public class WorkforceDemandList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Values in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<WorkforceDemand> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
