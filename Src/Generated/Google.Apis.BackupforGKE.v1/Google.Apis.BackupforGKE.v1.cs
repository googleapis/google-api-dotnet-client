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

namespace Google.Apis.BackupforGKE.v1
{
    /// <summary>The BackupforGKE Service.</summary>
    public class BackupforGKEService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BackupforGKEService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BackupforGKEService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "gkebackup";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://gkebackup.googleapis.com/";
        #else
            "https://gkebackup.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://gkebackup.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Backup for GKE API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Backup for GKE API.</summary>
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

    /// <summary>A base abstract class for BackupforGKE requests.</summary>
    public abstract class BackupforGKEBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BackupforGKEBaseServiceRequest instance.</summary>
        protected BackupforGKEBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes BackupforGKE parameter list.</summary>
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
                BackupPlans = new BackupPlansResource(service);
                Operations = new OperationsResource(service);
                RestorePlans = new RestorePlansResource(service);
            }

            /// <summary>Gets the BackupPlans resource.</summary>
            public virtual BackupPlansResource BackupPlans { get; }

            /// <summary>The "backupPlans" collection of methods.</summary>
            public class BackupPlansResource
            {
                private const string Resource = "backupPlans";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BackupPlansResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Backups = new BackupsResource(service);
                }

                /// <summary>Gets the Backups resource.</summary>
                public virtual BackupsResource Backups { get; }

                /// <summary>The "backups" collection of methods.</summary>
                public class BackupsResource
                {
                    private const string Resource = "backups";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public BackupsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        VolumeBackups = new VolumeBackupsResource(service);
                    }

                    /// <summary>Gets the VolumeBackups resource.</summary>
                    public virtual VolumeBackupsResource VolumeBackups { get; }

                    /// <summary>The "volumeBackups" collection of methods.</summary>
                    public class VolumeBackupsResource
                    {
                        private const string Resource = "volumeBackups";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public VolumeBackupsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Retrieve the details of a single VolumeBackup.</summary>
                        /// <param name="name">
                        /// Required. Full name of the VolumeBackup resource. Format:
                        /// projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Retrieve the details of a single VolumeBackup.</summary>
                        public class GetRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.VolumeBackup>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full name of the VolumeBackup resource. Format:
                            /// projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+/backups/[^/]+/volumeBackups/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                        {
                            return new GetIamPolicyRequest(service, resource);
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        public class GetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
                        {
                            /// <summary>Constructs a new GetIamPolicy request.</summary>
                            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                            {
                                Resource = resource;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy is being requested. See the operation
                            /// documentation for the appropriate value for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>
                            /// Optional. The maximum policy version that will be used to format the policy. Valid
                            /// values are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests
                            /// for policies with any conditional role bindings must specify version 3. Policies with no
                            /// conditional role bindings may specify any valid value or leave the field unset. The
                            /// policy in the response might use the policy version that you specified, or it might use
                            /// a lower policy version. For example, if you specify version 3, but the policy has no
                            /// conditional role bindings, the response uses version 1. To learn which resources support
                            /// conditions in their IAM policies, see the [IAM
                            /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "getIamPolicy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+/backups/[^/]+/volumeBackups/[^/]+$",
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

                        /// <summary>Lists the VolumeBackups for a given Backup.</summary>
                        /// <param name="parent">
                        /// Required. The Backup that contains the VolumeBackups to list. Format:
                        /// projects/*/locations/*/backupPlans/*/backups/*
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists the VolumeBackups for a given Backup.</summary>
                        public class ListRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.ListVolumeBackupsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The Backup that contains the VolumeBackups to list. Format:
                            /// projects/*/locations/*/backupPlans/*/backups/*
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Field match expression used to filter the results.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Field by which to sort the results.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// The target number of results to return in a single response. If not specified, a default
                            /// value will be chosen by the service. Note that the response may inclue a partial list
                            /// and a caller should only rely on the response's next_page_token to determine if there
                            /// are more instances left to be queried.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// The value of next_page_token received from a previous `ListVolumeBackups` call. Provide
                            /// this to retrieve the subsequent page in a multi-page list of results. When paginating,
                            /// all other parameters provided to `ListVolumeBackups` must match the call that provided
                            /// the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/volumeBackups";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+/backups/[^/]+$",
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
                        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                        /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource)
                        {
                            return new SetIamPolicyRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                        /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                        /// </summary>
                        public class SetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
                        {
                            /// <summary>Constructs a new SetIamPolicy request.</summary>
                            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                            {
                                Resource = resource;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy is being specified. See the operation
                            /// documentation for the appropriate value for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "setIamPolicy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+/backups/[^/]+/volumeBackups/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource)
                        {
                            return new TestIamPermissionsRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        public class TestIamPermissionsRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsResponse>
                        {
                            /// <summary>Constructs a new TestIamPermissions request.</summary>
                            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                            Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "testIamPermissions";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+resource}:testIamPermissions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+/backups/[^/]+/volumeBackups/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Creates a Backup for the given BackupPlan.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The BackupPlan within which to create the Backup. Format:
                    /// projects/*/locations/*/backupPlans/*
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.BackupforGKE.v1.Data.Backup body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a Backup for the given BackupPlan.</summary>
                    public class CreateRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.Backup body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The BackupPlan within which to create the Backup. Format:
                        /// projects/*/locations/*/backupPlans/*
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The client-provided short name for the Backup resource. This name must: - be between 1 and
                        /// 63 characters long (inclusive) - consist of only lower-case ASCII letters, numbers, and
                        /// dashes - start with a lower-case letter - end with a lower-case letter or number - be unique
                        /// within the set of Backups in this BackupPlan
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("backupId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string BackupId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BackupforGKE.v1.Data.Backup Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/backups";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+$",
                            });
                            RequestParameters.Add("backupId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "backupId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes an existing Backup.</summary>
                    /// <param name="name">
                    /// Required. Name of the Backup resource. Format: projects/*/locations/*/backupPlans/*/backups/*
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes an existing Backup.</summary>
                    public class DeleteRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the Backup resource. Format:
                        /// projects/*/locations/*/backupPlans/*/backups/*
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If provided, this value must match the current value of the target Backup's etag field or
                        /// the request is rejected.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// If set to true, any VolumeBackups below this Backup will also be deleted. Otherwise, the
                        /// request will only succeed if the Backup has no VolumeBackups.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+/backups/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                            {
                                Name = "force",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Retrieve the details of a single Backup.</summary>
                    /// <param name="name">
                    /// Required. Full name of the Backup resource. Format:
                    /// projects/*/locations/*/backupPlans/*/backups/*
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Retrieve the details of a single Backup.</summary>
                    public class GetRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Backup>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full name of the Backup resource. Format:
                        /// projects/*/locations/*/backupPlans/*/backups/*
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+/backups/[^/]+$",
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

                    /// <summary>Lists the Backups for a given BackupPlan.</summary>
                    /// <param name="parent">
                    /// Required. The BackupPlan that contains the Backups to list. Format:
                    /// projects/*/locations/*/backupPlans/*
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the Backups for a given BackupPlan.</summary>
                    public class ListRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.ListBackupsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The BackupPlan that contains the Backups to list. Format:
                        /// projects/*/locations/*/backupPlans/*
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Field match expression used to filter the results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Field by which to sort the results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The target number of results to return in a single response. If not specified, a default
                        /// value will be chosen by the service. Note that the response may inclue a partial list and a
                        /// caller should only rely on the response's next_page_token to determine if there are more
                        /// instances left to be queried.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The value of next_page_token received from a previous `ListBackups` call. Provide this to
                        /// retrieve the subsequent page in a multi-page list of results. When paginating, all other
                        /// parameters provided to `ListBackups` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/backups";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+$",
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

                    /// <summary>Update a Backup.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The fully qualified name of the Backup.
                    /// projects/*/locations/*/backupPlans/*/backups/*
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.BackupforGKE.v1.Data.Backup body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Update a Backup.</summary>
                    public class PatchRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.Backup body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The fully qualified name of the Backup.
                        /// projects/*/locations/*/backupPlans/*/backups/*
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// This is used to specify the fields to be overwritten in the Backup targeted for update. The
                        /// values for each of these updated fields will be taken from the `backup_plan` provided with
                        /// this request. Field names are relative to the root of the resource. If no `update_mask` is
                        /// provided, all fields in `backup` will be written to the target Backup resource. Note that
                        /// OUTPUT_ONLY and IMMUTABLE fields in `backup` are ignored and are not used to update the
                        /// target Backup.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BackupforGKE.v1.Data.Backup Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+/backups/[^/]+$",
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
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:testIamPermissions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+/backups/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new BackupPlan in a given location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location within which to create the BackupPlan. Format: projects/*/locations/*
                /// </param>
                public virtual CreateRequest Create(Google.Apis.BackupforGKE.v1.Data.BackupPlan body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new BackupPlan in a given location.</summary>
                public class CreateRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.BackupPlan body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location within which to create the BackupPlan. Format: projects/*/locations/*
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The client-provided short name for the BackupPlan resource. This name must: - be
                    /// between 1 and 63 characters long (inclusive) - consist of only lower-case ASCII letters,
                    /// numbers, and dashes - start with a lower-case letter - end with a lower-case letter or number -
                    /// be unique within the set of BackupPlans in this location
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("backupPlanId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BackupPlanId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BackupforGKE.v1.Data.BackupPlan Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupPlans";

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
                        RequestParameters.Add("backupPlanId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "backupPlanId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes an existing BackupPlan.</summary>
                /// <param name="name">
                /// Required. Fully qualified BackupPlan name. Format: projects/*/locations/*/backupPlans/*
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes an existing BackupPlan.</summary>
                public class DeleteRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Fully qualified BackupPlan name. Format: projects/*/locations/*/backupPlans/*
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If provided, this value must match the current value of the target BackupPlan's etag field or
                    /// the request is rejected.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Retrieve the details of a single BackupPlan.</summary>
                /// <param name="name">
                /// Required. Fully qualified BackupPlan name. Format: projects/*/locations/*/backupPlans/*
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieve the details of a single BackupPlan.</summary>
                public class GetRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.BackupPlan>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Fully qualified BackupPlan name. Format: projects/*/locations/*/backupPlans/*
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+$",
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
                public class GetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
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
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+$",
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

                /// <summary>Lists BackupPlans in a given location.</summary>
                /// <param name="parent">
                /// Required. The location that contains the BackupPlans to list. Format: projects/*/locations/*
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists BackupPlans in a given location.</summary>
                public class ListRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.ListBackupPlansResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location that contains the BackupPlans to list. Format: projects/*/locations/*
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Field match expression used to filter the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field by which to sort the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The target number of results to return in a single response. If not specified, a default value
                    /// will be chosen by the service. Note that the response may inclue a partial list and a caller
                    /// should only rely on the response's next_page_token to determine if there are more instances left
                    /// to be queried.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value of next_page_token received from a previous `ListBackupPlans` call. Provide this to
                    /// retrieve the subsequent page in a multi-page list of results. When paginating, all other
                    /// parameters provided to `ListBackupPlans` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupPlans";

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

                /// <summary>Update a BackupPlan.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The full name of the BackupPlan resource. Format: projects/*/locations/*/backupPlans/*
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BackupforGKE.v1.Data.BackupPlan body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update a BackupPlan.</summary>
                public class PatchRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.BackupPlan body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The full name of the BackupPlan resource. Format:
                    /// projects/*/locations/*/backupPlans/*
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// This is used to specify the fields to be overwritten in the BackupPlan targeted for update. The
                    /// values for each of these updated fields will be taken from the `backup_plan` provided with this
                    /// request. Field names are relative to the root of the resource (e.g., `description`,
                    /// `backup_config.include_volume_data`, etc.) If no `update_mask` is provided, all fields in
                    /// `backup_plan` will be written to the target BackupPlan resource. Note that OUTPUT_ONLY and
                    /// IMMUTABLE fields in `backup_plan` are ignored and are not used to update the target BackupPlan.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BackupforGKE.v1.Data.BackupPlan Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+$",
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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+$",
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
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningCancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningCancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningCancelOperationRequest Body { get; set; }

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
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
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
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
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
                public class ListRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningListOperationsResponse>
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

            /// <summary>Gets the RestorePlans resource.</summary>
            public virtual RestorePlansResource RestorePlans { get; }

            /// <summary>The "restorePlans" collection of methods.</summary>
            public class RestorePlansResource
            {
                private const string Resource = "restorePlans";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RestorePlansResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Restores = new RestoresResource(service);
                }

                /// <summary>Gets the Restores resource.</summary>
                public virtual RestoresResource Restores { get; }

                /// <summary>The "restores" collection of methods.</summary>
                public class RestoresResource
                {
                    private const string Resource = "restores";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RestoresResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        VolumeRestores = new VolumeRestoresResource(service);
                    }

                    /// <summary>Gets the VolumeRestores resource.</summary>
                    public virtual VolumeRestoresResource VolumeRestores { get; }

                    /// <summary>The "volumeRestores" collection of methods.</summary>
                    public class VolumeRestoresResource
                    {
                        private const string Resource = "volumeRestores";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public VolumeRestoresResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Retrieve the details of a single VolumeRestore.</summary>
                        /// <param name="name">
                        /// Required. Full name of the VolumeRestore resource. Format:
                        /// projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Retrieve the details of a single VolumeRestore.</summary>
                        public class GetRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.VolumeRestore>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full name of the VolumeRestore resource. Format:
                            /// projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+/restores/[^/]+/volumeRestores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                        {
                            return new GetIamPolicyRequest(service, resource);
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        public class GetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
                        {
                            /// <summary>Constructs a new GetIamPolicy request.</summary>
                            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                            {
                                Resource = resource;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy is being requested. See the operation
                            /// documentation for the appropriate value for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>
                            /// Optional. The maximum policy version that will be used to format the policy. Valid
                            /// values are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests
                            /// for policies with any conditional role bindings must specify version 3. Policies with no
                            /// conditional role bindings may specify any valid value or leave the field unset. The
                            /// policy in the response might use the policy version that you specified, or it might use
                            /// a lower policy version. For example, if you specify version 3, but the policy has no
                            /// conditional role bindings, the response uses version 1. To learn which resources support
                            /// conditions in their IAM policies, see the [IAM
                            /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "getIamPolicy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+/restores/[^/]+/volumeRestores/[^/]+$",
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

                        /// <summary>Lists the VolumeRestores for a given Restore.</summary>
                        /// <param name="parent">
                        /// Required. The Restore that contains the VolumeRestores to list. Format:
                        /// projects/*/locations/*/restorePlans/*/restores/*
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists the VolumeRestores for a given Restore.</summary>
                        public class ListRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.ListVolumeRestoresResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The Restore that contains the VolumeRestores to list. Format:
                            /// projects/*/locations/*/restorePlans/*/restores/*
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Field match expression used to filter the results.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Field by which to sort the results.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// The target number of results to return in a single response. If not specified, a default
                            /// value will be chosen by the service. Note that the response may inclue a partial list
                            /// and a caller should only rely on the response's next_page_token to determine if there
                            /// are more instances left to be queried.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// The value of next_page_token received from a previous `ListVolumeRestores` call. Provide
                            /// this to retrieve the subsequent page in a multi-page list of results. When paginating,
                            /// all other parameters provided to `ListVolumeRestores` must match the call that provided
                            /// the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/volumeRestores";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+/restores/[^/]+$",
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
                        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                        /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource)
                        {
                            return new SetIamPolicyRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                        /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                        /// </summary>
                        public class SetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
                        {
                            /// <summary>Constructs a new SetIamPolicy request.</summary>
                            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                            {
                                Resource = resource;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy is being specified. See the operation
                            /// documentation for the appropriate value for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "setIamPolicy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+/restores/[^/]+/volumeRestores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource)
                        {
                            return new TestIamPermissionsRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        public class TestIamPermissionsRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsResponse>
                        {
                            /// <summary>Constructs a new TestIamPermissions request.</summary>
                            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                            Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "testIamPermissions";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+resource}:testIamPermissions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+/restores/[^/]+/volumeRestores/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Creates a new Restore for the given RestorePlan.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The RestorePlan within which to create the Restore. Format:
                    /// projects/*/locations/*/restorePlans/*
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.BackupforGKE.v1.Data.Restore body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new Restore for the given RestorePlan.</summary>
                    public class CreateRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.Restore body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The RestorePlan within which to create the Restore. Format:
                        /// projects/*/locations/*/restorePlans/*
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The client-provided short name for the Restore resource. This name must: - be
                        /// between 1 and 63 characters long (inclusive) - consist of only lower-case ASCII letters,
                        /// numbers, and dashes - start with a lower-case letter - end with a lower-case letter or
                        /// number - be unique within the set of Restores in this RestorePlan.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("restoreId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RestoreId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BackupforGKE.v1.Data.Restore Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/restores";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+$",
                            });
                            RequestParameters.Add("restoreId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "restoreId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes an existing Restore.</summary>
                    /// <param name="name">
                    /// Required. Full name of the Restore Format: projects/*/locations/*/restorePlans/*/restores/*
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes an existing Restore.</summary>
                    public class DeleteRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full name of the Restore Format: projects/*/locations/*/restorePlans/*/restores/*
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If provided, this value must match the current value of the target Restore's etag field or
                        /// the request is rejected.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// If set to true, any VolumeRestores below this restore will also be deleted. Otherwise, the
                        /// request will only succeed if the restore has no VolumeRestores.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+/restores/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                            {
                                Name = "force",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Retrieves the details of a single Restore.</summary>
                    /// <param name="name">
                    /// Required. Name of the restore resource. Format: projects/*/locations/*/restorePlans/*/restores/*
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Retrieves the details of a single Restore.</summary>
                    public class GetRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Restore>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the restore resource. Format:
                        /// projects/*/locations/*/restorePlans/*/restores/*
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+/restores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+/restores/[^/]+$",
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

                    /// <summary>Lists the Restores for a given RestorePlan.</summary>
                    /// <param name="parent">
                    /// Required. The RestorePlan that contains the Restores to list. Format:
                    /// projects/*/locations/*/restorePlans/*
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the Restores for a given RestorePlan.</summary>
                    public class ListRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.ListRestoresResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The RestorePlan that contains the Restores to list. Format:
                        /// projects/*/locations/*/restorePlans/*
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Field match expression used to filter the results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Field by which to sort the results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The target number of results to return in a single response. If not specified, a default
                        /// value will be chosen by the service. Note that the response may inclue a partial list and a
                        /// caller should only rely on the response's next_page_token to determine if there are more
                        /// instances left to be queried.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The value of next_page_token received from a previous `ListRestores` call. Provide this to
                        /// retrieve the subsequent page in a multi-page list of results. When paginating, all other
                        /// parameters provided to `ListRestores` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/restores";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+$",
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

                    /// <summary>Update a Restore.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The full name of the Restore resource. Format:
                    /// projects/*/locations/*/restorePlans/*/restores/*
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.BackupforGKE.v1.Data.Restore body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Update a Restore.</summary>
                    public class PatchRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.Restore body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The full name of the Restore resource. Format:
                        /// projects/*/locations/*/restorePlans/*/restores/*
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// This is used to specify the fields to be overwritten in the Restore targeted for update. The
                        /// values for each of these updated fields will be taken from the `restore` provided with this
                        /// request. Field names are relative to the root of the resource. If no `update_mask` is
                        /// provided, all fields in `restore` will be written to the target Restore resource. Note that
                        /// OUTPUT_ONLY and IMMUTABLE fields in `restore` are ignored and are not used to update the
                        /// target Restore.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BackupforGKE.v1.Data.Restore Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+/restores/[^/]+$",
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
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+/restores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:testIamPermissions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+/restores/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new RestorePlan in a given location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location within which to create the RestorePlan. Format: projects/*/locations/*
                /// </param>
                public virtual CreateRequest Create(Google.Apis.BackupforGKE.v1.Data.RestorePlan body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new RestorePlan in a given location.</summary>
                public class CreateRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.RestorePlan body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location within which to create the RestorePlan. Format: projects/*/locations/*
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The client-provided short name for the RestorePlan resource. This name must: - be
                    /// between 1 and 63 characters long (inclusive) - consist of only lower-case ASCII letters,
                    /// numbers, and dashes - start with a lower-case letter - end with a lower-case letter or number -
                    /// be unique within the set of RestorePlans in this location
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("restorePlanId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RestorePlanId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BackupforGKE.v1.Data.RestorePlan Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/restorePlans";

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
                        RequestParameters.Add("restorePlanId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "restorePlanId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes an existing RestorePlan.</summary>
                /// <param name="name">
                /// Required. Fully qualified RestorePlan name. Format: projects/*/locations/*/restorePlans/*
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes an existing RestorePlan.</summary>
                public class DeleteRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Fully qualified RestorePlan name. Format: projects/*/locations/*/restorePlans/*
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If provided, this value must match the current value of the target RestorePlan's etag field or
                    /// the request is rejected.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// If set to true, any Restores below this RestorePlan will also be deleted. Otherwise, the request
                    /// will only succeed if the RestorePlan has no Restores.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Retrieve the details of a single RestorePlan.</summary>
                /// <param name="name">
                /// Required. Fully qualified RestorePlan name. Format: projects/*/locations/*/restorePlans/*
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieve the details of a single RestorePlan.</summary>
                public class GetRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.RestorePlan>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Fully qualified RestorePlan name. Format: projects/*/locations/*/restorePlans/*
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+$",
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
                public class GetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
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
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+$",
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

                /// <summary>Lists RestorePlans in a given location.</summary>
                /// <param name="parent">
                /// Required. The location that contains the RestorePlans to list. Format: projects/*/locations/*
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists RestorePlans in a given location.</summary>
                public class ListRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.ListRestorePlansResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location that contains the RestorePlans to list. Format: projects/*/locations/*
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Field match expression used to filter the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field by which to sort the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The target number of results to return in a single response. If not specified, a default value
                    /// will be chosen by the service. Note that the response may inclue a partial list and a caller
                    /// should only rely on the response's next_page_token to determine if there are more instances left
                    /// to be queried.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value of next_page_token received from a previous `ListRestorePlans` call. Provide this to
                    /// retrieve the subsequent page in a multi-page list of results. When paginating, all other
                    /// parameters provided to `ListRestorePlans` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/restorePlans";

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

                /// <summary>Update a RestorePlan.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The full name of the RestorePlan resource. Format:
                /// projects/*/locations/*/restorePlans/*.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BackupforGKE.v1.Data.RestorePlan body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update a RestorePlan.</summary>
                public class PatchRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.RestorePlan body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The full name of the RestorePlan resource. Format:
                    /// projects/*/locations/*/restorePlans/*.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// This is used to specify the fields to be overwritten in the RestorePlan targeted for update. The
                    /// values for each of these updated fields will be taken from the `restore_plan` provided with this
                    /// request. Field names are relative to the root of the resource. If no `update_mask` is provided,
                    /// all fields in `restore_plan` will be written to the target RestorePlan resource. Note that
                    /// OUTPUT_ONLY and IMMUTABLE fields in `restore_plan` are ignored and are not used to update the
                    /// target RestorePlan.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BackupforGKE.v1.Data.RestorePlan Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+$",
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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.BackupforGKE.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.BackupforGKE.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/restorePlans/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
            /// operation result. It does not cancel the operation. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`.
            /// </summary>
            /// <param name="name">The name of the operation resource to be deleted.</param>
            public virtual DeleteOperationsRequest DeleteOperations(string name)
            {
                return new DeleteOperationsRequest(service, name);
            }

            /// <summary>
            /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
            /// operation result. It does not cancel the operation. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`.
            /// </summary>
            public class DeleteOperationsRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Empty>
            {
                /// <summary>Constructs a new DeleteOperations request.</summary>
                public DeleteOperationsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The name of the operation resource to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deleteOperations";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/operations";

                /// <summary>Initializes DeleteOperations parameter list.</summary>
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.Location>
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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : BackupforGKEBaseServiceRequest<Google.Apis.BackupforGKE.v1.Data.ListLocationsResponse>
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
                public override string RestPath => "v1/{+name}/locations";

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
namespace Google.Apis.BackupforGKE.v1.Data
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

    /// <summary>
    /// Represents a request to perform a single point-in-time capture of some portion of the state of a GKE cluster,
    /// the record of the backup operation itself, and an anchor for the underlying artifacts that comprise the Backup
    /// (the config backup and VolumeBackups). Next id: 28
    /// </summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. If True, all namespaces were included in the Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allNamespaces")]
        public virtual System.Nullable<bool> AllNamespaces { get; set; }

        /// <summary>Output only. Information about the GKE cluster from which this Backup was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterMetadata")]
        public virtual ClusterMetadata ClusterMetadata { get; set; }

        /// <summary>Output only. Completion time of the Backup</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual object CompleteTime { get; set; }

        /// <summary>Output only. The size of the config backup in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configBackupSizeBytes")]
        public virtual System.Nullable<long> ConfigBackupSizeBytes { get; set; }

        /// <summary>
        /// Output only. Whether or not the Backup contains Kubernetes Secrets. Controlled by the parent BackupPlan's
        /// include_secrets value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containsSecrets")]
        public virtual System.Nullable<bool> ContainsSecrets { get; set; }

        /// <summary>
        /// Output only. Whether or not the Backup contains volume data. Controlled by the parent BackupPlan's
        /// include_volume_data value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containsVolumeData")]
        public virtual System.Nullable<bool> ContainsVolumeData { get; set; }

        /// <summary>Output only. The timestamp when this Backup resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Minimum age for this Backup (in days). If this field is set to a non-zero value, the Backup will be "locked"
        /// against deletion (either manual or automatic deletion) for the number of days provided (measured from the
        /// creation time of the Backup). MUST be an integer value between 0-90 (inclusive). Defaults to parent
        /// BackupPlan's backup_delete_lock_days setting and may only be increased (either at creation time or in a
        /// subsequent update).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteLockDays")]
        public virtual System.Nullable<int> DeleteLockDays { get; set; }

        /// <summary>
        /// Output only. The time at which an existing delete lock will expire for this backup (calculated from
        /// create_time + delete_lock_days).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteLockExpireTime")]
        public virtual object DeleteLockExpireTime { get; set; }

        /// <summary>User specified descriptive string for this Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. The customer managed encryption key that was used to encrypt the Backup's artifacts. Inherited
        /// from the parent BackupPlan's encryption_key value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual EncryptionKey EncryptionKey { get; set; }

        /// <summary>
        /// Output only. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates
        /// of a backup from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform backup updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `GetBackup`, and systems are expected to put that etag in the request to `UpdateBackup`
        /// or `DeleteBackup` to ensure that their change will be applied to the same version of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>A set of custom labels supplied by user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. This flag indicates whether this Backup resource was created manually by a user or via a
        /// schedule in the BackupPlan. A value of True means that the Backup was created manually.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manual")]
        public virtual System.Nullable<bool> Manual { get; set; }

        /// <summary>
        /// Output only. The fully qualified name of the Backup. projects/*/locations/*/backupPlans/*/backups/*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The total number of Kubernetes Pods contained in the Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podCount")]
        public virtual System.Nullable<int> PodCount { get; set; }

        /// <summary>Output only. The total number of Kubernetes resources included in the Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceCount")]
        public virtual System.Nullable<int> ResourceCount { get; set; }

        /// <summary>
        /// The age (in days) after which this Backup will be automatically deleted. Must be an integer value &amp;gt;=
        /// 0: - If 0, no automatic deletion will occur for this Backup. - If not 0, this must be &amp;gt;=
        /// delete_lock_days. Once a Backup is created, this value may only be increased. Defaults to the parent
        /// BackupPlan's backup_retain_days value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retainDays")]
        public virtual System.Nullable<int> RetainDays { get; set; }

        /// <summary>
        /// Output only. The time at which this Backup will be automatically deleted (calculated from create_time +
        /// retain_days).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retainExpireTime")]
        public virtual object RetainExpireTime { get; set; }

        /// <summary>
        /// Output only. If set, the list of ProtectedApplications whose resources were included in the Backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedApplications")]
        public virtual NamespacedNames SelectedApplications { get; set; }

        /// <summary>Output only. If set, the list of namespaces that were included in the Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedNamespaces")]
        public virtual Namespaces SelectedNamespaces { get; set; }

        /// <summary>
        /// Output only. The total size of the Backup in bytes = config backup size + sum(volume backup sizes)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>Output only. Current state of the Backup</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Human-readable description of why the backup is in the current `state`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateReason")]
        public virtual string StateReason { get; set; }

        /// <summary>
        /// Output only. Server generated global unique identifier of
        /// [UUID4](https://en.wikipedia.org/wiki/Universally_unique_identifier)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The timestamp when this Backup resource was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Output only. The total number of volume backups contained in the Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeCount")]
        public virtual System.Nullable<int> VolumeCount { get; set; }
    }

    /// <summary>BackupConfig defines the configuration of Backups created via this BackupPlan.</summary>
    public class BackupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If True, include all namespaced resources</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allNamespaces")]
        public virtual System.Nullable<bool> AllNamespaces { get; set; }

        /// <summary>
        /// This defines a customer managed encryption key that will be used to encrypt the "config" portion (the
        /// Kubernetes resources) of Backups created via this plan. Default (empty): Config backup artifacts will not be
        /// encrypted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual EncryptionKey EncryptionKey { get; set; }

        /// <summary>
        /// This flag specifies whether Kubernetes Secret resources should be included when they fall into the scope of
        /// Backups. Default: False
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeSecrets")]
        public virtual System.Nullable<bool> IncludeSecrets { get; set; }

        /// <summary>
        /// This flag specifies whether volume data should be backed up when PVCs are included in the scope of a Backup.
        /// Default: False
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeVolumeData")]
        public virtual System.Nullable<bool> IncludeVolumeData { get; set; }

        /// <summary>If set, include just the resources referenced by the listed ProtectedApplications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedApplications")]
        public virtual NamespacedNames SelectedApplications { get; set; }

        /// <summary>If set, include just the resources in the listed namespaces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedNamespaces")]
        public virtual Namespaces SelectedNamespaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the configuration and scheduling for a "line" of Backups.</summary>
    public class BackupPlan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines the configuration of Backups created via this BackupPlan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfig")]
        public virtual BackupConfig BackupConfig { get; set; }

        /// <summary>Defines a schedule for automatic Backup creation via this BackupPlan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupSchedule")]
        public virtual Schedule BackupSchedule { get; set; }

        /// <summary>
        /// Required. Immutable. The source cluster from which Backups will be created via this BackupPlan. Valid
        /// formats: - projects/*/locations/*/clusters/* - projects/*/zones/*/clusters/*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>Output only. The timestamp when this BackupPlan resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// This flag indicates whether this BackupPlan has been deactivated. Setting this field to True locks the
        /// BackupPlan such that no further updates will be allowed (except deletes), including the deactivated field
        /// itself. It also prevents any new Backups from being created via this BackupPlan (including scheduled
        /// Backups). Default: False
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deactivated")]
        public virtual System.Nullable<bool> Deactivated { get; set; }

        /// <summary>User specified descriptive string for this BackupPlan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates
        /// of a backup plan from overwriting each other. It is strongly suggested that systems make use of the 'etag'
        /// in the read-modify-write cycle to perform BackupPlan updates in order to avoid race conditions: An `etag` is
        /// returned in the response to `GetBackupPlan`, and systems are expected to put that etag in the request to
        /// `UpdateBackupPlan` or `DeleteBackupPlan` to ensure that their change will be applied to the same version of
        /// the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>A set of custom labels supplied by user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The full name of the BackupPlan resource. Format: projects/*/locations/*/backupPlans/*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The number of Kubernetes Pods backed up in the last successful Backup created via this
        /// BackupPlan.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectedPodCount")]
        public virtual System.Nullable<int> ProtectedPodCount { get; set; }

        /// <summary>RetentionPolicy governs lifecycle of Backups created under this plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionPolicy")]
        public virtual RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Output only. Server generated global unique identifier of
        /// [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The timestamp when this BackupPlan resource was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
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
        /// Specifies the principals requesting access for a Google Cloud resource. `members` can have the following
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

    /// <summary>Information about the GKE cluster from which this Backup was created.</summary>
    public class ClusterMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Anthos version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anthosVersion")]
        public virtual string AnthosVersion { get; set; }

        /// <summary>A list of the Backup for GKE CRD versions found in the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupCrdVersions")]
        public virtual System.Collections.Generic.IDictionary<string, string> BackupCrdVersions { get; set; }

        /// <summary>
        /// The source cluster from which this Backup was created. Valid formats: - projects/*/locations/*/clusters/* -
        /// projects/*/zones/*/clusters/* This is inherited from the parent BackupPlan's cluster field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>GKE version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeVersion")]
        public virtual string GkeVersion { get; set; }

        /// <summary>The Kubernetes server version of the source cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("k8sVersion")]
        public virtual string K8sVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies the cluster-scoped resources to restore from the Backup.</summary>
    public class ClusterResourceRestoreScope : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of "types" of cluster-scoped resources to be restored from the Backup. An empty list means that NO
        /// cluster-scoped resources will be restored. Note that Namespaces and PersistentVolume restoration is handled
        /// separately and is not governed by this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedGroupKinds")]
        public virtual System.Collections.Generic.IList<GroupKind> SelectedGroupKinds { get; set; }

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

    /// <summary>Defined a customer managed encryption key that will be used to encrypt Backup artifacts.</summary>
    public class EncryptionKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud KMS encryption key. Format: projects/*/locations/*/keyRings/*/cryptoKeys/*</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpKmsEncryptionKey")]
        public virtual string GcpKmsEncryptionKey { get; set; }

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

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class GoogleLongrunningCancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class GoogleLongrunningListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
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
    /// This is a direct map to the Kubernetes GroupKind type
    /// [GroupKind](https://godoc.org/k8s.io/apimachinery/pkg/runtime/schema#GroupKind) and is used for identifying
    /// specific "types" of resources to restore.
    /// </summary>
    public class GroupKind : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// API group string of a Kubernetes resource, e.g. "apiextensions.k8s.io", "storage.k8s.io", etc. Note: use
        /// empty string for core API group
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroup")]
        public virtual string ResourceGroup { get; set; }

        /// <summary>Kind of a Kubernetes resource, e.g. "CustomResourceDefinition", "StorageClass", etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceKind")]
        public virtual string ResourceKind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListBackupPlans.</summary>
    public class ListBackupPlansResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of BackupPlans matching the given criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPlans")]
        public virtual System.Collections.Generic.IList<BackupPlan> BackupPlans { get; set; }

        /// <summary>
        /// A token which may be sent as page_token in a subsequent `ListBackupPlans` call to retrieve the next page of
        /// results. If this field is omitted or empty, then there are no more results to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListBackups.</summary>
    public class ListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Backups matching the given criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual System.Collections.Generic.IList<Backup> Backups { get; set; }

        /// <summary>
        /// A token which may be sent as page_token in a subsequent `ListBackups` call to retrieve the next page of
        /// results. If this field is omitted or empty, then there are no more results to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>Response message for ListRestorePlans.</summary>
    public class ListRestorePlansResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token which may be sent as page_token in a subsequent `ListRestorePlans` call to retrieve the next page of
        /// results. If this field is omitted or empty, then there are no more results to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of RestorePlans matching the given criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restorePlans")]
        public virtual System.Collections.Generic.IList<RestorePlan> RestorePlans { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListRestores.</summary>
    public class ListRestoresResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token which may be sent as page_token in a subsequent `ListRestores` call to retrieve the next page of
        /// results. If this field is omitted or empty, then there are no more results to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Restores matching the given criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restores")]
        public virtual System.Collections.Generic.IList<Restore> Restores { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListVolumeBackups.</summary>
    public class ListVolumeBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token which may be sent as page_token in a subsequent `ListVolumeBackups` call to retrieve the next page
        /// of results. If this field is omitted or empty, then there are no more results to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of VolumeBackups matching the given criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeBackups")]
        public virtual System.Collections.Generic.IList<VolumeBackup> VolumeBackups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListVolumeRestores.</summary>
    public class ListVolumeRestoresResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token which may be sent as page_token in a subsequent `ListVolumeRestores` call to retrieve the next page
        /// of results. If this field is omitted or empty, then there are no more results to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of VolumeRestores matching the given criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeRestores")]
        public virtual System.Collections.Generic.IList<VolumeRestore> VolumeRestores { get; set; }

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

    /// <summary>A reference to a namespaced resource in Kubernetes.</summary>
    public class NamespacedName : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Kubernetes resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The Namespace of the Kubernetes resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of namespaced Kubernetes resources.</summary>
    public class NamespacedNames : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of namespaced Kubernetes resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespacedNames")]
        public virtual System.Collections.Generic.IList<NamespacedName> NamespacedNamesValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of Kubernetes Namespaces</summary>
    public class Namespaces : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Kubernetes Namespaces</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaces")]
        public virtual System.Collections.Generic.IList<string> NamespacesValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
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

    /// <summary>
    /// Represents both a request to Restore some portion of a Backup into a target GKE cluster and a record of the
    /// restore operation itself. Next id: 18
    /// </summary>
    public class Restore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. A reference to the Backup used as the source from which this Restore will restore. Note
        /// that this Backup must be a sub-resource of the RestorePlan's backup_plan. Format:
        /// projects/*/locations/*/backupPlans/*/backups/*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>
        /// Output only. The target cluster into which this Restore will restore data. Valid formats: -
        /// projects/*/locations/*/clusters/* - projects/*/zones/*/clusters/* Inherited from parent RestorePlan's
        /// cluster value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>Output only. Timestamp of when the restore operation completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual object CompleteTime { get; set; }

        /// <summary>Output only. The timestamp when this Restore resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>User specified descriptive string for this Restore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates
        /// of a restore from overwriting each other. It is strongly suggested that systems make use of the `etag` in
        /// the read-modify-write cycle to perform restore updates in order to avoid race conditions: An `etag` is
        /// returned in the response to `GetRestore`, and systems are expected to put that etag in the request to
        /// `UpdateRestore` or `DeleteRestore` to ensure that their change will be applied to the same version of the
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>A set of custom labels supplied by user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The full name of the Restore resource. Format: projects/*/locations/*/restorePlans/*/restores/*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Number of resources excluded during the restore execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcesExcludedCount")]
        public virtual System.Nullable<int> ResourcesExcludedCount { get; set; }

        /// <summary>Output only. Number of resources that failed to be restored during the restore execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcesFailedCount")]
        public virtual System.Nullable<int> ResourcesFailedCount { get; set; }

        /// <summary>Output only. Number of resources restored during the restore execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcesRestoredCount")]
        public virtual System.Nullable<int> ResourcesRestoredCount { get; set; }

        /// <summary>
        /// Output only. Configuration of the Restore. Inherited from parent RestorePlan's restore_config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreConfig")]
        public virtual RestoreConfig RestoreConfig { get; set; }

        /// <summary>Output only. The current state of the Restore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Human-readable description of why the Restore is in its current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateReason")]
        public virtual string StateReason { get; set; }

        /// <summary>
        /// Output only. Server generated global unique identifier of
        /// [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The timestamp when this Restore resource was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Output only. Number of volumes restored during the restore execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumesRestoredCount")]
        public virtual System.Nullable<int> VolumesRestoredCount { get; set; }
    }

    /// <summary>Configuration of a restore. Next id: 9</summary>
    public class RestoreConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Restore all namespaced resources in the Backup if set to "True". Specifying this field to "False" is an
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allNamespaces")]
        public virtual System.Nullable<bool> AllNamespaces { get; set; }

        /// <summary>
        /// Defines the behavior for handling the situation where cluster-scoped resources being restored already exist
        /// in the target cluster. This MUST be set to a value other than CLUSTER_RESOURCE_CONFLICT_POLICY_UNSPECIFIED
        /// if cluster_resource_restore_scope is not empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterResourceConflictPolicy")]
        public virtual string ClusterResourceConflictPolicy { get; set; }

        /// <summary>
        /// Identifies the cluster-scoped resources to restore from the Backup. Not specifying it means NO cluster
        /// resource will be restored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterResourceRestoreScope")]
        public virtual ClusterResourceRestoreScope ClusterResourceRestoreScope { get; set; }

        /// <summary>
        /// Defines the behavior for handling the situation where sets of namespaced resources being restored already
        /// exist in the target cluster. This MUST be set to a value other than
        /// NAMESPACED_RESOURCE_RESTORE_MODE_UNSPECIFIED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespacedResourceRestoreMode")]
        public virtual string NamespacedResourceRestoreMode { get; set; }

        /// <summary>
        /// A list of selected ProtectedApplications to restore. The listed ProtectedApplications and all the resources
        /// to which they refer will be restored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedApplications")]
        public virtual NamespacedNames SelectedApplications { get; set; }

        /// <summary>
        /// A list of selected Namespaces to restore from the Backup. The listed Namespaces and all resources contained
        /// in them will be restored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedNamespaces")]
        public virtual Namespaces SelectedNamespaces { get; set; }

        /// <summary>
        /// A list of transformation rules to be applied against Kubernetes resources as they are selected for
        /// restoration from a Backup. Rules are executed in order defined - this order matters, as changes made by a
        /// rule may impact the filtering logic of subsequent rules. An empty list means no substitution will occur.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutionRules")]
        public virtual System.Collections.Generic.IList<SubstitutionRule> SubstitutionRules { get; set; }

        /// <summary>
        /// Specifies the mechanism to be used to restore volume data. Default: VOLUME_DATA_RESTORE_POLICY_UNSPECIFIED
        /// (will be treated as NO_VOLUME_DATA_RESTORATION).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeDataRestorePolicy")]
        public virtual string VolumeDataRestorePolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration of a potential series of Restore operations to be performed against Backups belong to a
    /// particular BackupPlan. Next id: 11
    /// </summary>
    public class RestorePlan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. A reference to the BackupPlan from which Backups may be used as the source for Restores
        /// created via this RestorePlan. Format: projects/*/locations/*/backupPlans/*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPlan")]
        public virtual string BackupPlan { get; set; }

        /// <summary>
        /// Required. Immutable. The target cluster into which Restores created via this RestorePlan will restore data.
        /// NOTE: the cluster's region must be the same as the RestorePlan. Valid formats: -
        /// projects/*/locations/*/clusters/* - projects/*/zones/*/clusters/*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>Output only. The timestamp when this RestorePlan resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>User specified descriptive string for this RestorePlan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates
        /// of a restore from overwriting each other. It is strongly suggested that systems make use of the `etag` in
        /// the read-modify-write cycle to perform restore updates in order to avoid race conditions: An `etag` is
        /// returned in the response to `GetRestorePlan`, and systems are expected to put that etag in the request to
        /// `UpdateRestorePlan` or `DeleteRestorePlan` to ensure that their change will be applied to the same version
        /// of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>A set of custom labels supplied by user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The full name of the RestorePlan resource. Format: projects/*/locations/*/restorePlans/*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Configuration of Restores created via this RestorePlan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreConfig")]
        public virtual RestoreConfig RestoreConfig { get; set; }

        /// <summary>
        /// Output only. Server generated global unique identifier of
        /// [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The timestamp when this RestorePlan resource was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>RetentionPolicy defines a Backup retention policy for a BackupPlan.</summary>
    public class RetentionPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Minimum age for Backups created via this BackupPlan (in days). This field MUST be an integer value between
        /// 0-90 (inclusive). A Backup created under this BackupPlan will NOT be deletable until it reaches Backup's
        /// (create_time + backup_delete_lock_days). Updating this field of a BackupPlan does NOT affect existing
        /// Backups under it. Backups created AFTER a successful update will inherit the new value. Default: 0 (no
        /// delete blocking)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupDeleteLockDays")]
        public virtual System.Nullable<int> BackupDeleteLockDays { get; set; }

        /// <summary>
        /// The default maximum age of a Backup created via this BackupPlan. This field MUST be an integer value
        /// &amp;gt;= 0. If specified, a Backup created under this BackupPlan will be automatically deleted after its
        /// age reaches (create_time + backup_retain_days). If not specified, Backups created under this BackupPlan will
        /// NOT be subject to automatic deletion. Updating this field does NOT affect existing Backups under it. Backups
        /// created AFTER a successful update will automatically pick up the new value. NOTE: backup_retain_days must be
        /// &amp;gt;= backup_delete_lock_days. Default: 0 (no automatic deletion)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRetainDays")]
        public virtual System.Nullable<int> BackupRetainDays { get; set; }

        /// <summary>
        /// This flag denotes whether the retention policy of this BackupPlan is locked. If set to True, no further
        /// update is allowed on this policy, including the `locked` field itself. Default: False
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locked")]
        public virtual System.Nullable<bool> Locked { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Schedule defines scheduling parameters for automatically creating Backups via this BackupPlan.
    /// </summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A standard [cron](https://wikipedia.com/wiki/cron) string that defines a repeating schedule for creating
        /// Backups via this BackupPlan. Default (empty): no automatic backup creation will occur.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cronSchedule")]
        public virtual string CronSchedule { get; set; }

        /// <summary>
        /// This flag denotes whether automatic Backup creation is paused for this BackupPlan. Default: False
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paused")]
        public virtual System.Nullable<bool> Paused { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
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

    /// <summary>
    /// A transformation rule to be applied against Kubernetes resources as they are selected for restoration from a
    /// Backup. A rule contains both filtering logic (which resources are subject to substitution) and substitution
    /// logic.
    /// </summary>
    public class SubstitutionRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This is the new value to set for any fields that pass the filtering and selection criteria. To remove a
        /// value from a Kubernetes resource, either leave this field unspecified, or set it to the empty string ("").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual string NewValue { get; set; }

        /// <summary>
        /// (Filtering parameter) This is a [regular expression] (https://en.wikipedia.org/wiki/Regular_expression) that
        /// is compared against the fields matched by the target_json_path expression (and must also have passed the
        /// previous filters). Substitution will not be performed against fields whose value does not match this
        /// expression. If this field is NOT specified, then ALL fields matched by the target_json_path expression will
        /// undergo substitution. Note that an empty (e.g., "", rather than unspecified) value for for this field will
        /// only match empty fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalValuePattern")]
        public virtual string OriginalValuePattern { get; set; }

        /// <summary>
        /// (Filtering parameter) Any resource subject to substitution must belong to one of the listed "types". If this
        /// field is not provided, no type filtering will be performed (all resources of all types matching previous
        /// filtering parameters will be candidates for substitution).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetGroupKinds")]
        public virtual System.Collections.Generic.IList<GroupKind> TargetGroupKinds { get; set; }

        /// <summary>
        /// Required. This is a [JSONPath] (https://kubernetes.io/docs/reference/kubectl/jsonpath/) expression that
        /// matches specific fields of candidate resources and it operates as both a filtering parameter (resources that
        /// are not matched with this expression will not be candidates for substitution) as well as a field identifier
        /// (identifies exactly which fields out of the candidate resources will be modified).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetJsonPath")]
        public virtual string TargetJsonPath { get; set; }

        /// <summary>
        /// (Filtering parameter) Any resource subject to substitution must be contained within one of the listed
        /// Kubernetes Namespace in the Backup. If this field is not provided, no namespace filtering will be performed
        /// (all resources in all Namespaces, including all cluster-scoped resources, will be candidates for
        /// substitution). To mix cluster-scoped and namespaced resources in the same rule, use an empty string ("") as
        /// one of the target namespaces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetNamespaces")]
        public virtual System.Collections.Generic.IList<string> TargetNamespaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as `*` or `storage.*`)
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

    /// <summary>
    /// Represents the backup of a specific persistent volume as a component of a Backup - both the record of the
    /// operation and a pointer to the underlying storage-specific artifacts. Next id: 14
    /// </summary>
    public class VolumeBackup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The timestamp when the associated underlying volume backup operation completed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual object CompleteTime { get; set; }

        /// <summary>Output only. The timestamp when this VolumeBackup resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The minimum size of the disk to which this VolumeBackup can be restored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeBytes")]
        public virtual System.Nullable<long> DiskSizeBytes { get; set; }

        /// <summary>
        /// Output only. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates
        /// of a volume backup from overwriting each other. It is strongly suggested that systems make use of the `etag`
        /// in the read-modify-write cycle to perform volume backup updates in order to avoid race conditions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. The format used for the volume backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// Output only. The full name of the VolumeBackup resource. Format:
        /// projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. A reference to the source Kubernetes PVC from which this VolumeBackup was created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePvc")]
        public virtual NamespacedName SourcePvc { get; set; }

        /// <summary>Output only. The current state of this VolumeBackup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. A human readable message explaining why the VolumeBackup is in its current state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>
        /// Output only. The aggregate size of the underlying artifacts associated with this VolumeBackup in the backup
        /// storage. This may change over time when multiple backups of the same volume share the same backup storage
        /// location. In particular, this is likely to increase in size when the immediately preceding backup of the
        /// same volume is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageBytes")]
        public virtual System.Nullable<long> StorageBytes { get; set; }

        /// <summary>
        /// Output only. Server generated global unique identifier of
        /// [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The timestamp when this VolumeBackup resource was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Output only. A storage system-specific opaque handle to the underlying volume backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeBackupHandle")]
        public virtual string VolumeBackupHandle { get; set; }
    }

    /// <summary>Represents the operation of restoring a volume from a VolumeBackup. Next id: 13</summary>
    public class VolumeRestore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The timestamp when the associated underlying volume restoration completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual object CompleteTime { get; set; }

        /// <summary>Output only. The timestamp when this VolumeRestore resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates
        /// of a volume restore from overwriting each other. It is strongly suggested that systems make use of the
        /// `etag` in the read-modify-write cycle to perform volume restore updates in order to avoid race conditions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Full name of the VolumeRestore resource. Format:
        /// projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current state of this VolumeRestore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. A human readable message explaining why the VolumeRestore is in its current state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>Output only. The reference to the target Kubernetes PVC to be restored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetPvc")]
        public virtual NamespacedName TargetPvc { get; set; }

        /// <summary>
        /// Output only. Server generated global unique identifier of
        /// [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The timestamp when this VolumeRestore resource was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Output only. The full name of the VolumeBackup from which the volume will be restored. Format:
        /// projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeBackup")]
        public virtual string VolumeBackup { get; set; }

        /// <summary>
        /// Output only. A storage system-specific opaque handler to the underlying volume created for the target PVC
        /// from the volume backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeHandle")]
        public virtual string VolumeHandle { get; set; }

        /// <summary>Output only. The type of volume provisioned</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeType")]
        public virtual string VolumeType { get; set; }
    }
}
