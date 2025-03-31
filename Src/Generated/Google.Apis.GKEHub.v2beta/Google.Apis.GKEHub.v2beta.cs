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

namespace Google.Apis.GKEHub.v2beta
{
    /// <summary>The GKEHub Service.</summary>
    public class GKEHubService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GKEHubService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GKEHubService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://gkehub.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://gkehub.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "gkehub";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the GKE Hub API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the GKE Hub API.</summary>
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

    /// <summary>A base abstract class for GKEHub requests.</summary>
    public abstract class GKEHubBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GKEHubBaseServiceRequest instance.</summary>
        protected GKEHubBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes GKEHub parameter list.</summary>
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
                Memberships = new MembershipsResource(service);
                Operations = new OperationsResource(service);
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
                    Features = new FeaturesResource(service);
                }

                /// <summary>Gets the Features resource.</summary>
                public virtual FeaturesResource Features { get; }

                /// <summary>The "features" collection of methods.</summary>
                public class FeaturesResource
                {
                    private const string Resource = "features";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FeaturesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates membershipFeature under a given parent.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of parent where the MembershipFeature will be created. Specified in the
                    /// format `projects/*/locations/*/memberships/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.GKEHub.v2beta.Data.MembershipFeature body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates membershipFeature under a given parent.</summary>
                    public class CreateRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v2beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v2beta.Data.MembershipFeature body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of parent where the MembershipFeature will be created. Specified in the
                        /// format `projects/*/locations/*/memberships/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The ID of the membership_feature to create.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("featureId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string FeatureId { get; set; }

                        /// <summary>Idempotent request UUID.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEHub.v2beta.Data.MembershipFeature Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta/{+parent}/features";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
                            });
                            RequestParameters.Add("featureId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "featureId",
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

                    /// <summary>Removes a membershipFeature.</summary>
                    /// <param name="name">
                    /// Required. The name of the membershipFeature to be deleted. Specified in the format
                    /// `projects/*/locations/*/memberships/*/features/*`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Removes a membershipFeature.</summary>
                    public class DeleteRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v2beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the membershipFeature to be deleted. Specified in the format
                        /// `projects/*/locations/*/memberships/*/features/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Idempotent request UUID.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+/features/[^/]+$",
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

                    /// <summary>
                    /// ========= MembershipFeature Services ========= Gets details of a membershipFeature.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The MembershipFeature resource name in the format
                    /// `projects/*/locations/*/memberships/*/features/*`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// ========= MembershipFeature Services ========= Gets details of a membershipFeature.
                    /// </summary>
                    public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v2beta.Data.MembershipFeature>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The MembershipFeature resource name in the format
                        /// `projects/*/locations/*/memberships/*/features/*`.
                        /// </summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+/features/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists MembershipFeatures in a given project and location.</summary>
                    /// <param name="parent">
                    /// Required. The parent where the MembershipFeature will be listed. In the format:
                    /// `projects/*/locations/*/memberships/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists MembershipFeatures in a given project and location.</summary>
                    public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v2beta.Data.ListMembershipFeaturesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent where the MembershipFeature will be listed. In the format:
                        /// `projects/*/locations/*/memberships/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Lists MembershipFeatures that match the filter expression, following the syntax outlined in
                        /// https://google.aip.dev/160. Examples: - Feature with the name "helloworld" in project
                        /// "foo-proj" and membership "member-bar": name =
                        /// "projects/foo-proj/locations/global/memberships/member-bar/features/helloworld" - Features
                        /// that have a label called `foo`: labels.foo:* - Features that have a label called `foo` whose
                        /// value is `bar`: labels.foo = bar
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// One or more fields to compare and use to sort the output. See
                        /// https://google.aip.dev/132#ordering.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// When requesting a 'page' of resources, `page_size` specifies number of resources to return.
                        /// If unspecified or set to 0, all resources will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Token returned by previous call to `ListFeatures` which specifies the position in the list
                        /// from where to continue listing the resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta/{+parent}/features";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
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

                    /// <summary>Updates an existing MembershipFeature.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource name of the membershipFeature, in the format:
                    /// `projects/{project}/locations/{location}/memberships/{membership}/features/{feature}`. Note that
                    /// `membershipFeatures` is shortened to `features` in the resource name. (see
                    /// http://go/aip/122#collection-identifiers)
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.GKEHub.v2beta.Data.MembershipFeature body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing MembershipFeature.</summary>
                    public class PatchRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v2beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v2beta.Data.MembershipFeature body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource name of the membershipFeature, in the format:
                        /// `projects/{project}/locations/{location}/memberships/{membership}/features/{feature}`. Note
                        /// that `membershipFeatures` is shortened to `features` in the resource name. (see
                        /// http://go/aip/122#collection-identifiers)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. If set to true, and the MembershipFeature is not found, a new MembershipFeature
                        /// will be created. In this situation, `update_mask` is ignored.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>Idempotent request UUID.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Required. Mask of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEHub.v2beta.Data.MembershipFeature Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+/features/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
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
                public virtual CancelRequest Cancel(Google.Apis.GKEHub.v2beta.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v2beta.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v2beta.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEHub.v2beta.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta/{+name}:cancel";

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
                public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v2beta.Data.Operation>
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
                public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v2beta.Data.ListOperationsResponse>
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
                    public override string RestPath => "v2beta/{+name}/operations";

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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v2beta.Data.Location>
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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v2beta.Data.ListLocationsResponse>
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
                /// Optional. A list of extra location types that should be used as conditions for controlling the
                /// visibility of the locations.
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
                public override string RestPath => "v2beta/{+name}/locations";

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
        }
    }
}
namespace Google.Apis.GKEHub.v2beta.Data
{
    /// <summary>State for App Dev Exp Feature.</summary>
    public class AppDevExperienceState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status of subcomponent that detects configured Service Mesh resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkingInstallSucceeded")]
        public virtual AppDevExperienceStatus NetworkingInstallSucceeded { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status specifies state for the subcomponent.</summary>
    public class AppDevExperienceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Code specifies AppDevExperienceFeature's subcomponent ready state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Description is populated if Code is Failed, explaining why it has failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Cloud Build**: Configurations for each Cloud Build enabled cluster.</summary>
    public class CloudBuildSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether it is allowed to run the privileged builds on the cluster or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPolicy")]
        public virtual string SecurityPolicy { get; set; }

        /// <summary>Version of the cloud build software on the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GKEUpgrade represents a GKE provided upgrade, e.g., control plane upgrade.</summary>
    public class ClusterUpgradeGKEUpgrade : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the upgrade, e.g., "k8s_control_plane".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Version of the upgrade, e.g., "1.22.1-gke.100".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// IgnoredMembership represents a membership ignored by the feature. A membership can be ignored because it was
    /// manually upgraded to a newer version than RC default.
    /// </summary>
    public class ClusterUpgradeIgnoredMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _ignoredTimeRaw;

        private object _ignoredTime;

        /// <summary>Time when the membership was first set to ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoredTime")]
        public virtual string IgnoredTimeRaw
        {
            get => _ignoredTimeRaw;
            set
            {
                _ignoredTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _ignoredTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="IgnoredTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IgnoredTimeDateTimeOffset instead.")]
        public virtual object IgnoredTime
        {
            get => _ignoredTime;
            set
            {
                _ignoredTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _ignoredTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="IgnoredTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? IgnoredTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IgnoredTimeRaw);
            set => IgnoredTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Reason why the membership is ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MembershipGKEUpgradeState is a GKEUpgrade and its state per-membership.</summary>
    public class ClusterUpgradeMembershipGKEUpgradeState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status of the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ClusterUpgradeUpgradeStatus Status { get; set; }

        /// <summary>Which upgrade to track the state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgrade")]
        public virtual ClusterUpgradeGKEUpgrade Upgrade { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Per-membership state for this feature.</summary>
    public class ClusterUpgradeState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether this membership is ignored by the feature. For example, manually upgraded clusters can be ignored if
        /// they are newer than the default versions of its release channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignored")]
        public virtual ClusterUpgradeIgnoredMembership Ignored { get; set; }

        /// <summary>Actual upgrade state against desired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgrades")]
        public virtual System.Collections.Generic.IList<ClusterUpgradeMembershipGKEUpgradeState> Upgrades { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UpgradeStatus provides status information for each upgrade.</summary>
    public class ClusterUpgradeUpgradeStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status code of the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Reason for this status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Last timestamp the status was updated.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Binauthz.</summary>
    public class ConfigManagementBinauthzConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether binauthz is enabled in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State for Binauthz.</summary>
    public class ConfigManagementBinauthzState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The version of binauthz that is installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual ConfigManagementBinauthzVersion Version { get; set; }

        /// <summary>The state of the binauthz webhook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhook")]
        public virtual string Webhook { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The version of binauthz.</summary>
    public class ConfigManagementBinauthzVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The version of the binauthz webhook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookVersion")]
        public virtual string WebhookVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Config Sync</summary>
    public class ConfigManagementConfigSync : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Configuration for deployment overrides.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentOverrides")]
        public virtual System.Collections.Generic.IList<ConfigManagementDeploymentOverride> DeploymentOverrides { get; set; }

        /// <summary>
        /// Optional. Enables the installation of ConfigSync. If set to true, ConfigSync resources will be created and
        /// the other ConfigSync fields will be applied if exist. If set to false, all other ConfigSync fields will be
        /// ignored, ConfigSync resources will be deleted. If omitted, ConfigSync resources will be managed depends on
        /// the presence of the git or oci field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Optional. Git repo configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("git")]
        public virtual ConfigManagementGitConfig Git { get; set; }

        /// <summary>
        /// Optional. The Email of the Google Cloud Service Account (GSA) used for exporting Config Sync metrics to
        /// Cloud Monitoring and Cloud Monarch when Workload Identity is enabled. The GSA should have the Monitoring
        /// Metric Writer (roles/monitoring.metricWriter) IAM role. The Kubernetes ServiceAccount `default` in the
        /// namespace `config-management-monitoring` should be bound to the GSA. Deprecated: If Workload Identity
        /// Federation for GKE is enabled, Google Cloud Service Account is no longer needed for exporting Config Sync
        /// metrics:
        /// https://cloud.google.com/kubernetes-engine/enterprise/config-sync/docs/how-to/monitor-config-sync-cloud-monitoring#custom-monitoring.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricsGcpServiceAccountEmail")]
        public virtual string MetricsGcpServiceAccountEmail { get; set; }

        /// <summary>Optional. OCI repo configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oci")]
        public virtual ConfigManagementOciConfig Oci { get; set; }

        /// <summary>
        /// Optional. Set to true to enable the Config Sync admission webhook to prevent drifts. If set to `false`,
        /// disables the Config Sync admission webhook and does not prevent drifts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preventDrift")]
        public virtual System.Nullable<bool> PreventDrift { get; set; }

        /// <summary>
        /// Optional. Specifies whether the Config Sync Repo is in "hierarchical" or "unstructured" mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFormat")]
        public virtual string SourceFormat { get; set; }

        /// <summary>Optional. Set to true to stop syncing configs for a single cluster. Default to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopSyncing")]
        public virtual System.Nullable<bool> StopSyncing { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The state of ConfigSync's deployment on a cluster.</summary>
    public class ConfigManagementConfigSyncDeploymentState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deployment state of admission-webhook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("admissionWebhook")]
        public virtual string AdmissionWebhook { get; set; }

        /// <summary>Deployment state of the git-sync pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitSync")]
        public virtual string GitSync { get; set; }

        /// <summary>Deployment state of the importer pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importer")]
        public virtual string Importer { get; set; }

        /// <summary>Deployment state of the monitor pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitor")]
        public virtual string Monitor { get; set; }

        /// <summary>Deployment state of otel-collector</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otelCollector")]
        public virtual string OtelCollector { get; set; }

        /// <summary>Deployment state of reconciler-manager pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconcilerManager")]
        public virtual string ReconcilerManager { get; set; }

        /// <summary>Deployment state of resource-group-controller-manager</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroupControllerManager")]
        public virtual string ResourceGroupControllerManager { get; set; }

        /// <summary>Deployment state of root-reconciler.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootReconciler")]
        public virtual string RootReconciler { get; set; }

        /// <summary>Deployment state of the syncer pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncer")]
        public virtual string Syncer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Errors pertaining to the installation of Config Sync</summary>
    public class ConfigManagementConfigSyncError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A string representing the user facing error message</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State information for ConfigSync.</summary>
    public class ConfigManagementConfigSyncState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Whether syncing resources to the cluster is stopped at the cluster level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterLevelStopSyncingState")]
        public virtual string ClusterLevelStopSyncingState { get; set; }

        /// <summary>Output only. The number of RootSync and RepoSync CRs in the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crCount")]
        public virtual System.Nullable<int> CrCount { get; set; }

        /// <summary>
        /// Output only. Information about the deployment of ConfigSync, including the version. of the various Pods
        /// deployed
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentState")]
        public virtual ConfigManagementConfigSyncDeploymentState DeploymentState { get; set; }

        /// <summary>Output only. Errors pertaining to the installation of Config Sync.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ConfigManagementConfigSyncError> Errors { get; set; }

        /// <summary>Output only. The state of the Reposync CRD</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reposyncCrd")]
        public virtual string ReposyncCrd { get; set; }

        /// <summary>Output only. The state of the RootSync CRD</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootsyncCrd")]
        public virtual string RootsyncCrd { get; set; }

        /// <summary>Output only. The state of CS This field summarizes the other fields in this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The state of ConfigSync's process to sync configs to a cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncState")]
        public virtual ConfigManagementSyncState SyncState { get; set; }

        /// <summary>Output only. The version of ConfigSync deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual ConfigManagementConfigSyncVersion Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specific versioning information pertaining to ConfigSync's Pods.</summary>
    public class ConfigManagementConfigSyncVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Version of the deployed admission-webhook pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("admissionWebhook")]
        public virtual string AdmissionWebhook { get; set; }

        /// <summary>Version of the deployed git-sync pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitSync")]
        public virtual string GitSync { get; set; }

        /// <summary>Version of the deployed importer pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importer")]
        public virtual string Importer { get; set; }

        /// <summary>Version of the deployed monitor pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitor")]
        public virtual string Monitor { get; set; }

        /// <summary>Version of the deployed otel-collector pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otelCollector")]
        public virtual string OtelCollector { get; set; }

        /// <summary>Version of the deployed reconciler-manager pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconcilerManager")]
        public virtual string ReconcilerManager { get; set; }

        /// <summary>Version of the deployed resource-group-controller-manager pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroupControllerManager")]
        public virtual string ResourceGroupControllerManager { get; set; }

        /// <summary>Version of the deployed reconciler container in root-reconciler pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootReconciler")]
        public virtual string RootReconciler { get; set; }

        /// <summary>Version of the deployed syncer pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncer")]
        public virtual string Syncer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a container override.</summary>
    public class ConfigManagementContainerOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerName")]
        public virtual string ContainerName { get; set; }

        /// <summary>Optional. The cpu limit of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuLimit")]
        public virtual string CpuLimit { get; set; }

        /// <summary>Optional. The cpu request of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuRequest")]
        public virtual string CpuRequest { get; set; }

        /// <summary>Optional. The memory limit of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryLimit")]
        public virtual string MemoryLimit { get; set; }

        /// <summary>Optional. The memory request of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryRequest")]
        public virtual string MemoryRequest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a deployment override.</summary>
    public class ConfigManagementDeploymentOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The containers of the deployment resource to be overridden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<ConfigManagementContainerOverride> Containers { get; set; }

        /// <summary>Required. The name of the deployment resource to be overridden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentName")]
        public virtual string DeploymentName { get; set; }

        /// <summary>Required. The namespace of the deployment resource to be overridden..</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentNamespace")]
        public virtual string DeploymentNamespace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model for a config file in the git repo with an associated Sync error.</summary>
    public class ConfigManagementErrorResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Group/version/kind of the resource that is causing an error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGvk")]
        public virtual ConfigManagementGroupVersionKind ResourceGvk { get; set; }

        /// <summary>Metadata name of the resource that is causing an error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Namespace of the resource that is causing an error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceNamespace")]
        public virtual string ResourceNamespace { get; set; }

        /// <summary>Path in the git repo of the erroneous config</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePath")]
        public virtual string SourcePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State of Policy Controller installation.</summary>
    public class ConfigManagementGatekeeperDeploymentState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status of gatekeeper-audit deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatekeeperAudit")]
        public virtual string GatekeeperAudit { get; set; }

        /// <summary>Status of gatekeeper-controller-manager pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatekeeperControllerManagerState")]
        public virtual string GatekeeperControllerManagerState { get; set; }

        /// <summary>Status of the pod serving the mutation webhook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatekeeperMutation")]
        public virtual string GatekeeperMutation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Git repo configuration for a single cluster.</summary>
    public class ConfigManagementGitConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Google Cloud Service Account Email used for auth when secret_type is gcpServiceAccount.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpServiceAccountEmail")]
        public virtual string GcpServiceAccountEmail { get; set; }

        /// <summary>Optional. URL for the HTTPS proxy to be used when communicating with the Git repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpsProxy")]
        public virtual string HttpsProxy { get; set; }

        /// <summary>
        /// Optional. The path within the Git repository that represents the top level of the repo to sync. Default: the
        /// root directory of the repository.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyDir")]
        public virtual string PolicyDir { get; set; }

        /// <summary>
        /// Required. Type of secret configured for access to the Git repo. Must be one of ssh, cookiefile, gcenode,
        /// token, gcpserviceaccount, githubapp or none. The validation of this is case-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretType")]
        public virtual string SecretType { get; set; }

        /// <summary>Optional. The branch of the repository to sync from. Default: master.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncBranch")]
        public virtual string SyncBranch { get; set; }

        /// <summary>Required. The URL of the Git repository to use as the source of truth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncRepo")]
        public virtual string SyncRepo { get; set; }

        /// <summary>Optional. Git revision (tag or hash) to check out. Default HEAD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncRev")]
        public virtual string SyncRev { get; set; }

        /// <summary>Optional. Period in seconds between consecutive syncs. Default: 15.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncWaitSecs")]
        public virtual System.Nullable<long> SyncWaitSecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Kubernetes object's GVK.</summary>
    public class ConfigManagementGroupVersionKind : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Kubernetes Group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>Kubernetes Kind</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Kubernetes Version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Hierarchy Controller.</summary>
    public class ConfigManagementHierarchyControllerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether hierarchical resource quota is enabled in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableHierarchicalResourceQuota")]
        public virtual System.Nullable<bool> EnableHierarchicalResourceQuota { get; set; }

        /// <summary>Whether pod tree labels are enabled in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePodTreeLabels")]
        public virtual System.Nullable<bool> EnablePodTreeLabels { get; set; }

        /// <summary>Whether Hierarchy Controller is enabled in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deployment state for Hierarchy Controller</summary>
    public class ConfigManagementHierarchyControllerDeploymentState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deployment state for Hierarchy Controller extension (e.g. v0.7.0-hc.1).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extension")]
        public virtual string Extension { get; set; }

        /// <summary>The deployment state for open source HNC (e.g. v0.7.0-hc.0).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hnc")]
        public virtual string Hnc { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State for Hierarchy Controller.</summary>
    public class ConfigManagementHierarchyControllerState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deployment state for Hierarchy Controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual ConfigManagementHierarchyControllerDeploymentState State { get; set; }

        /// <summary>The version for Hierarchy Controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual ConfigManagementHierarchyControllerVersion Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Version for Hierarchy Controller.</summary>
    public class ConfigManagementHierarchyControllerVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Version for Hierarchy Controller extension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extension")]
        public virtual string Extension { get; set; }

        /// <summary>Version for open source HNC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hnc")]
        public virtual string Hnc { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Errors pertaining to the installation of ACM.</summary>
    public class ConfigManagementInstallError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A string representing the user facing error message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>OCI repo configuration for a single cluster.</summary>
    public class ConfigManagementOciConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Google Cloud Service Account Email used for auth when secret_type is gcpServiceAccount.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpServiceAccountEmail")]
        public virtual string GcpServiceAccountEmail { get; set; }

        /// <summary>
        /// Optional. The absolute path of the directory that contains the local resources. Default: the root directory
        /// of the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyDir")]
        public virtual string PolicyDir { get; set; }

        /// <summary>
        /// Required. Type of secret configured for access to the OCI repo. Must be one of gcenode, gcpserviceaccount,
        /// k8sserviceaccount or none. The validation of this is case-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretType")]
        public virtual string SecretType { get; set; }

        /// <summary>
        /// Required. The OCI image repository URL for the package to sync from. e.g.
        /// `LOCATION-docker.pkg.dev/PROJECT_ID/REPOSITORY_NAME/PACKAGE_NAME`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncRepo")]
        public virtual string SyncRepo { get; set; }

        /// <summary>Optional. Period in seconds between consecutive syncs. Default: 15.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncWaitSecs")]
        public virtual System.Nullable<long> SyncWaitSecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State information for an ACM's Operator.</summary>
    public class ConfigManagementOperatorState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state of the Operator's deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentState")]
        public virtual string DeploymentState { get; set; }

        /// <summary>Install errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ConfigManagementInstallError> Errors { get; set; }

        /// <summary>The semenatic version number of the operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Policy Controller</summary>
    public class ConfigManagementPolicyController : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Sets the interval for Policy Controller Audit Scans (in seconds). When set to 0, this disables audit
        /// functionality altogether.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditIntervalSeconds")]
        public virtual System.Nullable<long> AuditIntervalSeconds { get; set; }

        /// <summary>
        /// Enables the installation of Policy Controller. If false, the rest of PolicyController fields take no effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// The set of namespaces that are excluded from Policy Controller checks. Namespaces do not need to currently
        /// exist on the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptableNamespaces")]
        public virtual System.Collections.Generic.IList<string> ExemptableNamespaces { get; set; }

        /// <summary>Logs all denies and dry run failures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logDeniesEnabled")]
        public virtual System.Nullable<bool> LogDeniesEnabled { get; set; }

        /// <summary>Monitoring specifies the configuration of monitoring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoring")]
        public virtual ConfigManagementPolicyControllerMonitoring Monitoring { get; set; }

        /// <summary>
        /// Enable or disable mutation in policy controller. If true, mutation CRDs, webhook and controller deployment
        /// will be deployed to the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutationEnabled")]
        public virtual System.Nullable<bool> MutationEnabled { get; set; }

        /// <summary>
        /// Enables the ability to use Constraint Templates that reference to objects other than the object currently
        /// being evaluated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referentialRulesEnabled")]
        public virtual System.Nullable<bool> ReferentialRulesEnabled { get; set; }

        /// <summary>Installs the default template library along with Policy Controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateLibraryInstalled")]
        public virtual System.Nullable<bool> TemplateLibraryInstalled { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last time this membership spec was updated.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State for the migration of PolicyController from ACM -&gt; PoCo Hub.</summary>
    public class ConfigManagementPolicyControllerMigration : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _copyTimeRaw;

        private object _copyTime;

        /// <summary>Last time this membership spec was copied to PoCo feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyTime")]
        public virtual string CopyTimeRaw
        {
            get => _copyTimeRaw;
            set
            {
                _copyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _copyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CopyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CopyTimeDateTimeOffset instead.")]
        public virtual object CopyTime
        {
            get => _copyTime;
            set
            {
                _copyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _copyTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CopyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CopyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CopyTimeRaw);
            set => CopyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Stage of the migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stage")]
        public virtual string Stage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// PolicyControllerMonitoring specifies the backends Policy Controller should export metrics to. For example, to
    /// specify metrics should be exported to Cloud Monitoring and Prometheus, specify backends: ["cloudmonitoring",
    /// "prometheus"]
    /// </summary>
    public class ConfigManagementPolicyControllerMonitoring : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the list of backends Policy Controller will export to. An empty list would effectively disable
        /// metrics export.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backends")]
        public virtual System.Collections.Generic.IList<string> Backends { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State for PolicyControllerState.</summary>
    public class ConfigManagementPolicyControllerState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state about the policy controller installation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentState")]
        public virtual ConfigManagementGatekeeperDeploymentState DeploymentState { get; set; }

        /// <summary>Record state of ACM -&gt; PoCo Hub migration for this feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migration")]
        public virtual ConfigManagementPolicyControllerMigration Migration { get; set; }

        /// <summary>The version of Gatekeeper Policy Controller deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual ConfigManagementPolicyControllerVersion Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The build version of Gatekeeper Policy Controller is using.</summary>
    public class ConfigManagementPolicyControllerVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The gatekeeper image tag that is composed of ACM version, git tag, build number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// **Anthos Config Management**: Configuration for a single cluster. Intended to parallel the ConfigManagement CR.
    /// </summary>
    public class ConfigManagementSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Binauthz conifguration for the cluster. Deprecated: This field will be ignored and should not be
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binauthz")]
        public virtual ConfigManagementBinauthzConfig Binauthz { get; set; }

        /// <summary>
        /// Optional. The user-specified cluster name used by Config Sync cluster-name-selector annotation or
        /// ClusterSelector, for applying configs to only a subset of clusters. Omit this field if the cluster's fleet
        /// membership name is used by Config Sync cluster-name-selector annotation or ClusterSelector. Set this field
        /// if a name different from the cluster's fleet membership name is used by Config Sync cluster-name-selector
        /// annotation or ClusterSelector.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>Optional. Config Sync configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configSync")]
        public virtual ConfigManagementConfigSync ConfigSync { get; set; }

        /// <summary>
        /// Optional. Hierarchy Controller configuration for the cluster. Deprecated: Configuring Hierarchy Controller
        /// through the configmanagement feature is no longer recommended. Use
        /// https://github.com/kubernetes-sigs/hierarchical-namespaces instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hierarchyController")]
        public virtual ConfigManagementHierarchyControllerConfig HierarchyController { get; set; }

        /// <summary>Optional. Enables automatic Feature management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("management")]
        public virtual string Management { get; set; }

        /// <summary>
        /// Optional. Policy Controller configuration for the cluster. Deprecated: Configuring Policy Controller through
        /// the configmanagement feature is no longer recommended. Use the policycontroller feature instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyController")]
        public virtual ConfigManagementPolicyController PolicyController { get; set; }

        /// <summary>Optional. Version of ACM installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Anthos Config Management**: State for a single cluster.</summary>
    public class ConfigManagementState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Binauthz status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binauthzState")]
        public virtual ConfigManagementBinauthzState BinauthzState { get; set; }

        /// <summary>
        /// Output only. This field is set to the `cluster_name` field of the Membership Spec if it is not empty.
        /// Otherwise, it is set to the cluster's fleet membership name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>Output only. Current sync status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configSyncState")]
        public virtual ConfigManagementConfigSyncState ConfigSyncState { get; set; }

        /// <summary>Output only. Hierarchy Controller status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hierarchyControllerState")]
        public virtual ConfigManagementHierarchyControllerState HierarchyControllerState { get; set; }

        /// <summary>
        /// Output only. Membership configuration in the cluster. This represents the actual state in the cluster, while
        /// the MembershipSpec in the FeatureSpec represents the intended state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipSpec")]
        public virtual ConfigManagementSpec MembershipSpec { get; set; }

        /// <summary>Output only. Current install status of ACM's Operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorState")]
        public virtual ConfigManagementOperatorState OperatorState { get; set; }

        /// <summary>Output only. PolicyController status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyControllerState")]
        public virtual ConfigManagementPolicyControllerState PolicyControllerState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An ACM created error representing a problem syncing configurations.</summary>
    public class ConfigManagementSyncError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An ACM defined error code</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A description of the error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>A list of config(s) associated with the error, if any</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorResources")]
        public virtual System.Collections.Generic.IList<ConfigManagementErrorResource> ErrorResources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State indicating an ACM's progress syncing configurations to a cluster.</summary>
    public class ConfigManagementSyncState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sync status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>
        /// A list of errors resulting from problematic configs. This list will be truncated after 100 errors, although
        /// it is unlikely for that many errors to simultaneously exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ConfigManagementSyncError> Errors { get; set; }

        /// <summary>Token indicating the state of the importer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importToken")]
        public virtual string ImportToken { get; set; }

        /// <summary>
        /// Deprecated: use last_sync_time instead. Timestamp of when ACM last successfully synced the repo. The time
        /// format is specified in https://golang.org/pkg/time/#Time.String
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSync")]
        public virtual string LastSync { get; set; }

        private string _lastSyncTimeRaw;

        private object _lastSyncTime;

        /// <summary>Timestamp type of when ACM last successfully synced the repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSyncTime")]
        public virtual string LastSyncTimeRaw
        {
            get => _lastSyncTimeRaw;
            set
            {
                _lastSyncTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastSyncTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastSyncTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastSyncTimeDateTimeOffset instead.")]
        public virtual object LastSyncTime
        {
            get => _lastSyncTime;
            set
            {
                _lastSyncTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastSyncTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LastSyncTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastSyncTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastSyncTimeRaw);
            set => LastSyncTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Token indicating the state of the repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceToken")]
        public virtual string SourceToken { get; set; }

        /// <summary>Token indicating the state of the syncer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncToken")]
        public virtual string SyncToken { get; set; }

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

    /// <summary>FeatureSpec contains user input per-feature spec information.</summary>
    public class FeatureSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloudbuild-specific FeatureSpec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudbuild")]
        public virtual CloudBuildSpec Cloudbuild { get; set; }

        /// <summary>Config Management FeatureSpec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configmanagement")]
        public virtual ConfigManagementSpec Configmanagement { get; set; }

        /// <summary>IdentityService FeatureSpec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityservice")]
        public virtual IdentityServiceSpec Identityservice { get; set; }

        /// <summary>
        /// Whether this per-Feature spec was inherited from a fleet-level default. This field can be updated by users
        /// by either overriding a Feature config (updated to USER implicitly) or setting to FLEET explicitly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual Origin Origin { get; set; }

        /// <summary>Policycontroller-specific FeatureSpec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policycontroller")]
        public virtual PolicyControllerSpec Policycontroller { get; set; }

        /// <summary>ServiceMesh Feature Spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicemesh")]
        public virtual ServiceMeshSpec Servicemesh { get; set; }

        /// <summary>Workloadcertificate-specific FeatureSpec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadcertificate")]
        public virtual WorkloadCertificateSpec Workloadcertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// FeatureState contains high-level state information and per-feature state information for this MembershipFeature.
    /// </summary>
    public class FeatureState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Appdevexperience specific state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appdevexperience")]
        public virtual AppDevExperienceState Appdevexperience { get; set; }

        /// <summary>Cluster upgrade state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterupgrade")]
        public virtual ClusterUpgradeState Clusterupgrade { get; set; }

        /// <summary>Config Management state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configmanagement")]
        public virtual ConfigManagementState Configmanagement { get; set; }

        /// <summary>Identity service state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityservice")]
        public virtual IdentityServiceState Identityservice { get; set; }

        /// <summary>Metering state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metering")]
        public virtual MeteringState Metering { get; set; }

        /// <summary>Policy Controller state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policycontroller")]
        public virtual PolicyControllerState Policycontroller { get; set; }

        /// <summary>Service mesh state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicemesh")]
        public virtual ServiceMeshState Servicemesh { get; set; }

        /// <summary>The high-level state of this MembershipFeature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual State State { get; set; }

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

    /// <summary>
    /// Configuration of an auth method for a member/cluster. Only one authentication method (e.g., OIDC and LDAP) can
    /// be set per AuthMethod.
    /// </summary>
    public class IdentityServiceAuthMethod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AzureAD specific Configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureadConfig")]
        public virtual IdentityServiceAzureADConfig AzureadConfig { get; set; }

        /// <summary>GoogleConfig specific configuration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleConfig")]
        public virtual IdentityServiceGoogleConfig GoogleConfig { get; set; }

        /// <summary>LDAP specific configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ldapConfig")]
        public virtual IdentityServiceLdapConfig LdapConfig { get; set; }

        /// <summary>Identifier for auth config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>OIDC specific configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidcConfig")]
        public virtual IdentityServiceOidcConfig OidcConfig { get; set; }

        /// <summary>Proxy server address to use for auth method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxy")]
        public virtual string Proxy { get; set; }

        /// <summary>SAML specific configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samlConfig")]
        public virtual IdentityServiceSamlConfig SamlConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the AzureAD Auth flow.</summary>
    public class IdentityServiceAzureADConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ID for the registered client application that makes authentication requests to the Azure AD identity
        /// provider.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Input only. Unencrypted AzureAD client secret will be passed to the GKE Hub CLH.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>Output only. Encrypted AzureAD client secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedClientSecret")]
        public virtual string EncryptedClientSecret { get; set; }

        /// <summary>Optional. Format of the AzureAD groups that the client wants for auth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupFormat")]
        public virtual string GroupFormat { get; set; }

        /// <summary>The redirect URL that kubectl uses for authorization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubectlRedirectUri")]
        public virtual string KubectlRedirectUri { get; set; }

        /// <summary>
        /// Kind of Azure AD account to be authenticated. Supported values are or for accounts belonging to a specific
        /// tenant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenant")]
        public virtual string Tenant { get; set; }

        /// <summary>Optional. Claim in the AzureAD ID Token that holds the user details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userClaim")]
        public virtual string UserClaim { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration options for the AIS diagnostic interface.</summary>
    public class IdentityServiceDiagnosticInterface : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Determines whether to enable the diagnostic interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>
        /// Determines the expiration time of the diagnostic interface enablement. When reached, requests to the
        /// interface would be automatically rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the Google Plugin Auth flow.</summary>
    public class IdentityServiceGoogleConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Disable automatic configuration of Google Plugin on supported platforms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disable")]
        public virtual System.Nullable<bool> Disable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the properties for locating and authenticating groups in the directory.</summary>
    public class IdentityServiceGroupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the subtree in the LDAP directory to search for group entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseDn")]
        public virtual string BaseDn { get; set; }

        /// <summary>
        /// Optional. Optional filter to be used when searching for groups a user belongs to. This can be used to
        /// explicitly match only certain groups in order to reduce the amount of groups returned for each user. This
        /// defaults to "(objectClass=Group)".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. The identifying name of each group a user belongs to. For example, if this is set to
        /// "distinguishedName" then RBACs and other group expectations should be written as full DNs. This defaults to
        /// "distinguishedName".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idAttribute")]
        public virtual string IdAttribute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Holds non-protocol-related configuration options.</summary>
    public class IdentityServiceIdentityServiceOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration options for the AIS diagnostic interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticInterface")]
        public virtual IdentityServiceDiagnosticInterface DiagnosticInterface { get; set; }

        /// <summary>Determines the lifespan of STS tokens issued by Anthos Identity Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionDuration")]
        public virtual object SessionDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the LDAP Auth flow.</summary>
    public class IdentityServiceLdapConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Contains the properties for locating and authenticating groups in the directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual IdentityServiceGroupConfig Group { get; set; }

        /// <summary>Required. Server settings for the external LDAP server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("server")]
        public virtual IdentityServiceServerConfig Server { get; set; }

        /// <summary>
        /// Required. Contains the credentials of the service account which is authorized to perform the LDAP search in
        /// the directory. The credentials can be supplied by the combination of the DN and password or the client
        /// certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual IdentityServiceServiceAccountConfig ServiceAccount { get; set; }

        /// <summary>Required. Defines where users exist in the LDAP directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual IdentityServiceUserConfig User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for OIDC Auth flow.</summary>
    public class IdentityServiceOidcConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PEM-encoded CA for OIDC provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateAuthorityData")]
        public virtual string CertificateAuthorityData { get; set; }

        /// <summary>ID for OIDC client application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Input only. Unencrypted OIDC client secret will be passed to the GKE Hub CLH.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>
        /// Flag to denote if reverse proxy is used to connect to auth provider. This flag should be set to true when
        /// provider is not reachable by Google Cloud Console.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployCloudConsoleProxy")]
        public virtual System.Nullable<bool> DeployCloudConsoleProxy { get; set; }

        /// <summary>Enable access token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAccessToken")]
        public virtual System.Nullable<bool> EnableAccessToken { get; set; }

        /// <summary>Output only. Encrypted OIDC Client secret</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedClientSecret")]
        public virtual string EncryptedClientSecret { get; set; }

        /// <summary>Comma-separated list of key-value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extraParams")]
        public virtual string ExtraParams { get; set; }

        /// <summary>Prefix to prepend to group name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupPrefix")]
        public virtual string GroupPrefix { get; set; }

        /// <summary>Claim in OIDC ID token that holds group information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupsClaim")]
        public virtual string GroupsClaim { get; set; }

        /// <summary>
        /// URI for the OIDC provider. This should point to the level below .well-known/openid-configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerUri")]
        public virtual string IssuerUri { get; set; }

        /// <summary>Registered redirect uri to redirect users going through OAuth flow using kubectl plugin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubectlRedirectUri")]
        public virtual string KubectlRedirectUri { get; set; }

        /// <summary>Comma-separated list of identifiers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual string Scopes { get; set; }

        /// <summary>Claim in OIDC ID token that holds username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userClaim")]
        public virtual string UserClaim { get; set; }

        /// <summary>Prefix to prepend to user name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPrefix")]
        public virtual string UserPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the SAML Auth flow.</summary>
    public class IdentityServiceSamlConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The mapping of additional user attributes like nickname, birthday and address etc.. `key` is the
        /// name of this additional attribute. `value` is a string presenting as CEL(common expression language, go/cel)
        /// used for getting the value from the resources. Take nickname as an example, in this case, `key` is
        /// "attribute.nickname" and `value` is "assertion.nickname".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeMapping")]
        public virtual System.Collections.Generic.IDictionary<string, string> AttributeMapping { get; set; }

        /// <summary>Optional. Prefix to prepend to group name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupPrefix")]
        public virtual string GroupPrefix { get; set; }

        /// <summary>
        /// Optional. The SAML attribute to read groups from. This value is expected to be a string and will be passed
        /// along as-is (with the option of being prefixed by the `group_prefix`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupsAttribute")]
        public virtual string GroupsAttribute { get; set; }

        /// <summary>Required. The list of IdP certificates to validate the SAML response against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityProviderCertificates")]
        public virtual System.Collections.Generic.IList<string> IdentityProviderCertificates { get; set; }

        /// <summary>Required. The entity ID of the SAML IdP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityProviderId")]
        public virtual string IdentityProviderId { get; set; }

        /// <summary>Required. The URI where the SAML IdP exposes the SSO service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityProviderSsoUri")]
        public virtual string IdentityProviderSsoUri { get; set; }

        /// <summary>
        /// Optional. The SAML attribute to read username from. If unspecified, the username will be read from the
        /// NameID element of the assertion in SAML response. This value is expected to be a string and will be passed
        /// along as-is (with the option of being prefixed by the `user_prefix`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAttribute")]
        public virtual string UserAttribute { get; set; }

        /// <summary>Optional. Prefix to prepend to user name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPrefix")]
        public virtual string UserPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Server settings for the external LDAP server.</summary>
    public class IdentityServiceServerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Contains a Base64 encoded, PEM formatted certificate authority certificate for the LDAP server.
        /// This must be provided for the "ldaps" and "startTLS" connections.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateAuthorityData")]
        public virtual string CertificateAuthorityData { get; set; }

        /// <summary>
        /// Optional. Defines the connection type to communicate with the LDAP server. If `starttls` or `ldaps` is
        /// specified, the certificate_authority_data should not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionType")]
        public virtual string ConnectionType { get; set; }

        /// <summary>
        /// Required. Defines the hostname or IP of the LDAP server. Port is optional and will default to 389, if
        /// unspecified. For example, "ldap.server.example" or "10.10.10.10:389".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the credentials of the service account which is authorized to perform the LDAP search in the directory.
    /// The credentials can be supplied by the combination of the DN and password or the client certificate.
    /// </summary>
    public class IdentityServiceServiceAccountConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Credentials for basic auth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleBindCredentials")]
        public virtual IdentityServiceSimpleBindCredentials SimpleBindCredentials { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The structure holds the LDAP simple binding credential.</summary>
    public class IdentityServiceSimpleBindCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The distinguished name(DN) of the service account object/user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dn")]
        public virtual string Dn { get; set; }

        /// <summary>Output only. The encrypted password of the service account object/user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedPassword")]
        public virtual string EncryptedPassword { get; set; }

        /// <summary>Required. Input only. The password of the service account object/user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**IdentityService**: Configuration for a single membership.</summary>
    public class IdentityServiceSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A member may support multiple auth methods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authMethods")]
        public virtual System.Collections.Generic.IList<IdentityServiceAuthMethod> AuthMethods { get; set; }

        /// <summary>Optional. non-protocol-related configuration options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityServiceOptions")]
        public virtual IdentityServiceIdentityServiceOptions IdentityServiceOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// **IdentityService**: State for a single membership, analyzed and reported by feature controller.
    /// </summary>
    public class IdentityServiceState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason of the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>
        /// Installed AIS version. This is the AIS version installed on this member. The values makes sense iff state is
        /// OK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installedVersion")]
        public virtual string InstalledVersion { get; set; }

        /// <summary>Last reconciled membership configuration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberConfig")]
        public virtual IdentityServiceSpec MemberConfig { get; set; }

        /// <summary>Deployment state on this member</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines where users exist in the LDAP directory.</summary>
    public class IdentityServiceUserConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the subtree in the LDAP directory to search for user entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseDn")]
        public virtual string BaseDn { get; set; }

        /// <summary>
        /// Optional. Filter to apply when searching for the user. This can be used to further restrict the user
        /// accounts which are allowed to login. This defaults to "(objectClass=User)".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. Determines which attribute to use as the user's identity after they are authenticated. This is
        /// distinct from the loginAttribute field to allow users to login with a username, but then have their actual
        /// identifier be an email address or full Distinguished Name (DN). For example, setting loginAttribute to
        /// "sAMAccountName" and identifierAttribute to "userPrincipalName" would allow a user to login as "bsmith", but
        /// actual RBAC policies for the user would be written as "bsmith@example.com". Using "userPrincipalName" is
        /// recommended since this will be unique for each user. This defaults to "userPrincipalName".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idAttribute")]
        public virtual string IdAttribute { get; set; }

        /// <summary>
        /// Optional. The name of the attribute which matches against the input username. This is used to find the user
        /// in the LDAP database e.g. "(=)" and is combined with the optional filter field. This defaults to
        /// "userPrincipalName".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginAttribute")]
        public virtual string LoginAttribute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// LifecycleState describes the state of a MembershipFeature *resource* in the GkeHub API. See `FeatureState` for
    /// the "running state" of the MembershipFeature.
    /// </summary>
    public class LifecycleState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The current state of the Feature resource in the Hub API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

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

    /// <summary>Response message for the `GkeHubFeature.ListMembershipFeatures` method.</summary>
    public class ListMembershipFeaturesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of matching MembershipFeatures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipFeatures")]
        public virtual System.Collections.Generic.IList<MembershipFeature> MembershipFeatures { get; set; }

        /// <summary>
        /// A token to request the next page of resources from the `ListMembershipFeatures` method. The value of an
        /// empty string means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of locations that could not be reached while fetching this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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
    /// MembershipFeature represents the settings and status of a Fleet Feature enabled on a single Fleet Membership.
    /// </summary>
    public class MembershipFeature : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. When the MembershipFeature resource was created.</summary>
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. When the MembershipFeature resource was deleted.</summary>
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

        /// <summary>GCP labels for this MembershipFeature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Lifecycle information of the resource itself.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual LifecycleState LifecycleState { get; set; }

        /// <summary>
        /// Output only. The resource name of the membershipFeature, in the format:
        /// `projects/{project}/locations/{location}/memberships/{membership}/features/{feature}`. Note that
        /// `membershipFeatures` is shortened to `features` in the resource name. (see
        /// http://go/aip/122#collection-identifiers)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Spec of this membershipFeature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual FeatureSpec Spec { get; set; }

        /// <summary>Output only. State of the this membershipFeature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual FeatureState State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. When the MembershipFeature resource was last updated.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Metering**: State for a single membership, analyzed and reported by feature controller.</summary>
    public class MeteringState : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastMeasurementTimeRaw;

        private object _lastMeasurementTime;

        /// <summary>The time stamp of the most recent measurement of the number of vCPUs in the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastMeasurementTime")]
        public virtual string LastMeasurementTimeRaw
        {
            get => _lastMeasurementTimeRaw;
            set
            {
                _lastMeasurementTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastMeasurementTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastMeasurementTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastMeasurementTimeDateTimeOffset instead.")]
        public virtual object LastMeasurementTime
        {
            get => _lastMeasurementTime;
            set
            {
                _lastMeasurementTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastMeasurementTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastMeasurementTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastMeasurementTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastMeasurementTimeRaw);
            set => LastMeasurementTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The vCPUs capacity in the cluster according to the most recent measurement (1/1000 precision).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preciseLastMeasuredClusterVcpuCapacity")]
        public virtual System.Nullable<float> PreciseLastMeasuredClusterVcpuCapacity { get; set; }

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
        public virtual GoogleRpcStatus Error { get; set; }

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

    /// <summary>Metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
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

    /// <summary>Origin defines where this FeatureSpec originated from.</summary>
    public class Origin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type specifies which type of origin is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BundleInstallSpec is the specification configuration for a single managed bundle.</summary>
    public class PolicyControllerBundleInstallSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>the set of namespaces to be exempted from the bundle</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedNamespaces")]
        public virtual System.Collections.Generic.IList<string> ExemptedNamespaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Policy Controller</summary>
    public class PolicyControllerHubConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Sets the interval for Policy Controller Audit Scans (in seconds). When set to 0, this disables audit
        /// functionality altogether.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditIntervalSeconds")]
        public virtual System.Nullable<long> AuditIntervalSeconds { get; set; }

        /// <summary>
        /// The maximum number of audit violations to be stored in a constraint. If not set, the internal default
        /// (currently 20) will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraintViolationLimit")]
        public virtual System.Nullable<long> ConstraintViolationLimit { get; set; }

        /// <summary>Map of deployment configs to deployments (“admission”, “audit”, “mutation”).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentConfigs")]
        public virtual System.Collections.Generic.IDictionary<string, PolicyControllerPolicyControllerDeploymentConfig> DeploymentConfigs { get; set; }

        /// <summary>
        /// The set of namespaces that are excluded from Policy Controller checks. Namespaces do not need to currently
        /// exist on the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptableNamespaces")]
        public virtual System.Collections.Generic.IList<string> ExemptableNamespaces { get; set; }

        /// <summary>
        /// The install_spec represents the intended state specified by the latest request that mutated install_spec in
        /// the feature spec, not the lifecycle state of the feature observed by the Hub feature controller that is
        /// reported in the feature state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installSpec")]
        public virtual string InstallSpec { get; set; }

        /// <summary>Logs all denies and dry run failures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logDeniesEnabled")]
        public virtual System.Nullable<bool> LogDeniesEnabled { get; set; }

        /// <summary>Monitoring specifies the configuration of monitoring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoring")]
        public virtual PolicyControllerMonitoringConfig Monitoring { get; set; }

        /// <summary>Enables the ability to mutate resources using Policy Controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutationEnabled")]
        public virtual System.Nullable<bool> MutationEnabled { get; set; }

        /// <summary>Specifies the desired policy content on the cluster</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyContent")]
        public virtual PolicyControllerPolicyContentSpec PolicyContent { get; set; }

        /// <summary>
        /// Enables the ability to use Constraint Templates that reference to objects other than the object currently
        /// being evaluated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referentialRulesEnabled")]
        public virtual System.Nullable<bool> ReferentialRulesEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MonitoringConfig specifies the backends Policy Controller should export metrics to. For example, to specify
    /// metrics should be exported to Cloud Monitoring and Prometheus, specify backends: ["cloudmonitoring",
    /// "prometheus"]
    /// </summary>
    public class PolicyControllerMonitoringConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the list of backends Policy Controller will export to. An empty list would effectively disable
        /// metrics export.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backends")]
        public virtual System.Collections.Generic.IList<string> Backends { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>OnClusterState represents the state of a sub-component of Policy Controller.</summary>
    public class PolicyControllerOnClusterState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Surface potential errors or information logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>The lifecycle state of this component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PolicyContentSpec defines the user's desired content configuration on the cluster.</summary>
    public class PolicyControllerPolicyContentSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// map of bundle name to BundleInstallSpec. The bundle name maps to the `bundleName` key in the
        /// `policycontroller.gke.io/constraintData` annotation on a constraint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundles")]
        public virtual System.Collections.Generic.IDictionary<string, PolicyControllerBundleInstallSpec> Bundles { get; set; }

        /// <summary>Configures the installation of the Template Library.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateLibrary")]
        public virtual PolicyControllerTemplateLibraryConfig TemplateLibrary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The state of the policy controller policy content</summary>
    public class PolicyControllerPolicyContentState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state of the any bundles included in the chosen version of the manifest</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleStates")]
        public virtual System.Collections.Generic.IDictionary<string, PolicyControllerOnClusterState> BundleStates { get; set; }

        /// <summary>
        /// The state of the referential data sync configuration. This could represent the state of either the syncSet
        /// object(s) or the config object, depending on the version of PoCo configured by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referentialSyncConfigState")]
        public virtual PolicyControllerOnClusterState ReferentialSyncConfigState { get; set; }

        /// <summary>The state of the template library</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateLibraryState")]
        public virtual PolicyControllerOnClusterState TemplateLibraryState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deployment-specific configuration.</summary>
    public class PolicyControllerPolicyControllerDeploymentConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Container resource requirements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerResources")]
        public virtual PolicyControllerResourceRequirements ContainerResources { get; set; }

        /// <summary>Pod affinity configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podAffinity")]
        public virtual string PodAffinity { get; set; }

        /// <summary>Pod anti-affinity enablement. Deprecated: use `pod_affinity` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podAntiAffinity")]
        public virtual System.Nullable<bool> PodAntiAffinity { get; set; }

        /// <summary>Pod tolerations of node taints.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podTolerations")]
        public virtual System.Collections.Generic.IList<PolicyControllerToleration> PodTolerations { get; set; }

        /// <summary>Pod replica count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaCount")]
        public virtual System.Nullable<long> ReplicaCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceList contains container resource requirements.</summary>
    public class PolicyControllerResourceList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CPU requirement expressed in Kubernetes resource units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual string Cpu { get; set; }

        /// <summary>Memory requirement expressed in Kubernetes resource units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memory")]
        public virtual string Memory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceRequirements describes the compute resource requirements.</summary>
    public class PolicyControllerResourceRequirements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed for use by the running container.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limits")]
        public virtual PolicyControllerResourceList Limits { get; set; }

        /// <summary>
        /// Requests describes the amount of compute resources reserved for the container by the kube-scheduler.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual PolicyControllerResourceList Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// **Policy Controller**: Configuration for a single cluster. Intended to parallel the PolicyController CR.
    /// </summary>
    public class PolicyControllerSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Policy Controller configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyControllerHubConfig")]
        public virtual PolicyControllerHubConfig PolicyControllerHubConfig { get; set; }

        /// <summary>Version of Policy Controller installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Policy Controller**: State for a single cluster.</summary>
    public class PolicyControllerState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Currently these include (also serving as map keys): 1. "admission" 2. "audit" 3. "mutation"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentStates")]
        public virtual System.Collections.Generic.IDictionary<string, PolicyControllerOnClusterState> ComponentStates { get; set; }

        /// <summary>The overall content state observed by the Hub Feature controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyContentState")]
        public virtual PolicyControllerPolicyContentState PolicyContentState { get; set; }

        /// <summary>The overall Policy Controller lifecycle state observed by the Hub Feature controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The config specifying which default library templates to install.</summary>
    public class PolicyControllerTemplateLibraryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configures the manner in which the template library is installed on the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installation")]
        public virtual string Installation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Toleration of a node taint.</summary>
    public class PolicyControllerToleration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Matches a taint effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effect")]
        public virtual string Effect { get; set; }

        /// <summary>Matches a taint key (not necessarily unique).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Matches a taint operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>Matches a taint value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AnalysisMessage is a single message produced by an analyzer, and it used to communicate to the end user about
    /// the state of their Service Mesh configuration.
    /// </summary>
    public class ServiceMeshAnalysisMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A UI can combine these args with a template (based on message_base.type) to produce an internationalized
        /// message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// A human readable description of what the error means. It is suitable for non-internationalize display
        /// purposes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Details common to all types of Istio and ServiceMesh analysis messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageBase")]
        public virtual ServiceMeshAnalysisMessageBase MessageBase { get; set; }

        /// <summary>
        /// A list of strings specifying the resource identifiers that were the cause of message generation. A "path"
        /// here may be: * MEMBERSHIP_ID if the cause is a specific member cluster *
        /// MEMBERSHIP_ID/(NAMESPACE\/)?RESOURCETYPE/NAME if the cause is a resource in a cluster
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcePaths")]
        public virtual System.Collections.Generic.IList<string> ResourcePaths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AnalysisMessageBase describes some common information that is needed for all messages.</summary>
    public class ServiceMeshAnalysisMessageBase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A url pointing to the Service Mesh or Istio documentation for this specific error type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationUrl")]
        public virtual string DocumentationUrl { get; set; }

        /// <summary>Represents how severe a message is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>Represents the specific type of a message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual ServiceMeshType Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Condition being reported.</summary>
    public class ServiceMeshCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unique identifier of the condition which describes the condition recognizable to the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A short summary about the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>Links contains actionable information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationLink")]
        public virtual string DocumentationLink { get; set; }

        /// <summary>Severity level of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status of control plane management.</summary>
    public class ServiceMeshControlPlaneManagement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explanation of state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<ServiceMeshStatusDetails> Details { get; set; }

        /// <summary>Output only. Implementation of managed control plane.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("implementation")]
        public virtual string Implementation { get; set; }

        /// <summary>LifecycleState of control plane management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status of data plane management. Only reported per-member.</summary>
    public class ServiceMeshDataPlaneManagement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explanation of the status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<ServiceMeshStatusDetails> Details { get; set; }

        /// <summary>Lifecycle status of data plane management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Service Mesh**: Spec for a single Membership for the servicemesh feature</summary>
    public class ServiceMeshSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies the API that will be used for configuring the mesh workloads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configApi")]
        public virtual string ConfigApi { get; set; }

        /// <summary>Deprecated: use `management` instead Enables automatic control plane management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlane")]
        public virtual string ControlPlane { get; set; }

        /// <summary>Determines which release channel to use for default injection and service mesh APIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultChannel")]
        public virtual string DefaultChannel { get; set; }

        /// <summary>Optional. Enables automatic Service Mesh management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("management")]
        public virtual string Management { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// **Service Mesh**: State for a single Membership, as analyzed by the Service Mesh Hub Controller.
    /// </summary>
    public class ServiceMeshState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Results of running Service Mesh analyzers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisMessages")]
        public virtual System.Collections.Generic.IList<ServiceMeshAnalysisMessage> AnalysisMessages { get; set; }

        /// <summary>Output only. List of conditions reported for this membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<ServiceMeshCondition> Conditions { get; set; }

        /// <summary>
        /// The API version (i.e. Istio CRD version) for configuring service mesh in this cluster. This version is
        /// influenced by the `default_channel` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configApiVersion")]
        public virtual string ConfigApiVersion { get; set; }

        /// <summary>Output only. Status of control plane management</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneManagement")]
        public virtual ServiceMeshControlPlaneManagement ControlPlaneManagement { get; set; }

        /// <summary>Output only. Status of data plane management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataPlaneManagement")]
        public virtual ServiceMeshDataPlaneManagement DataPlaneManagement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured and human-readable details for a status.</summary>
    public class ServiceMeshStatusDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A machine-readable code that further describes a broad status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Human-readable explanation of code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A unique identifier for the type of message. Display_name is intended to be human-readable, code is intended to
    /// be machine readable. There should be a one-to-one mapping between display_name and code. (i.e. do not re-use
    /// display_names or codes between message types.) See istio.analysis.v1alpha1.AnalysisMessageBase.Type
    /// </summary>
    public class ServiceMeshType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A 7 character code matching `^IST[0-9]{4}$` or `^ASM[0-9]{4}$`, intended to uniquely identify the message
        /// type. (e.g. "IST0001" is mapped to the "InternalError" message type.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>
        /// A human-readable name for the message type. e.g. "InternalError", "PodMissingProxy". This should be the same
        /// for all messages of the same type. (This corresponds to the `name` field in open-source Istio.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>High-level state of a MembershipFeature.</summary>
    public class State : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The high-level, machine-readable status of this MembershipFeature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A human-readable description of the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The time this status and any related Feature-specific details were updated.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**WorkloadCertificate**: The membership-specific input for WorkloadCertificate feature.</summary>
    public class WorkloadCertificateSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CertificateManagement specifies workload certificate management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateManagement")]
        public virtual string CertificateManagement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
