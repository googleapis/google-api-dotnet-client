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

namespace Google.Apis.DriveLabels.v2beta
{
    /// <summary>The DriveLabels Service.</summary>
    public class DriveLabelsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DriveLabelsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DriveLabelsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Labels = new LabelsResource(this);
            Limits = new LimitsResource(this);
            Users = new UsersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "drivelabels";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://drivelabels.googleapis.com/";
        #else
            "https://drivelabels.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://drivelabels.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Labels resource.</summary>
        public virtual LabelsResource Labels { get; }

        /// <summary>Gets the Limits resource.</summary>
        public virtual LimitsResource Limits { get; }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }
    }

    /// <summary>A base abstract class for DriveLabels requests.</summary>
    public abstract class DriveLabelsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DriveLabelsBaseServiceRequest instance.</summary>
        protected DriveLabelsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DriveLabels parameter list.</summary>
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

    /// <summary>The "labels" collection of methods.</summary>
    public class LabelsResource
    {
        private const string Resource = "labels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LabelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Locks = new LocksResource(service);
            Permissions = new PermissionsResource(service);
            Revisions = new RevisionsResource(service);
        }

        /// <summary>Gets the Locks resource.</summary>
        public virtual LocksResource Locks { get; }

        /// <summary>The "locks" collection of methods.</summary>
        public class LocksResource
        {
            private const string Resource = "locks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists the Locks on a Label.</summary>
            /// <param name="parent">Required. Label on which Locks are applied. Format: labels/{label}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the Locks on a Label.</summary>
            public class ListRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaListLabelLocksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Label on which Locks are applied. Format: labels/{label}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Maximum number of Locks to return per page. Default: 100. Max: 200.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The token of the page to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/{+parent}/locks";

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
                        Pattern = @"^labels/[^/]+$",
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

        /// <summary>Gets the Permissions resource.</summary>
        public virtual PermissionsResource Permissions { get; }

        /// <summary>The "permissions" collection of methods.</summary>
        public class PermissionsResource
        {
            private const string Resource = "permissions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PermissionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Deletes Label permissions. Permissions affect the Label resource as a whole, are not revisioned, and do
            /// not require publishing.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="labelsId"><c>null</c></param>
            public virtual BatchDeleteRequest BatchDelete(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchDeleteLabelPermissionsRequest body, string labelsId)
            {
                return new BatchDeleteRequest(service, body, labelsId);
            }

            /// <summary>
            /// Deletes Label permissions. Permissions affect the Label resource as a whole, are not revisioned, and do
            /// not require publishing.
            /// </summary>
            public class BatchDeleteRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new BatchDelete request.</summary>
                public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchDeleteLabelPermissionsRequest body, string labelsId) : base(service)
                {
                    LabelsId = labelsId;
                    Body = body;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("labelsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LabelsId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchDeleteLabelPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchDelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/labels/{labelsId}/permissions:batchDelete";

                /// <summary>Initializes BatchDelete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("labelsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates Label permissions. If a permission for the indicated principal doesn't exist, a new Label
            /// Permission is created, otherwise the existing permission is updated. Permissions affect the Label
            /// resource as a whole, are not revisioned, and do not require publishing.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent Label resource name shared by all permissions being updated. Format: labels/{label}
            /// If this is set, the parent field in the UpdateLabelPermissionRequest messages must either be empty or
            /// match this field.
            /// </param>
            public virtual BatchUpdateRequest BatchUpdate(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchUpdateLabelPermissionsRequest body, string parent)
            {
                return new BatchUpdateRequest(service, body, parent);
            }

            /// <summary>
            /// Updates Label permissions. If a permission for the indicated principal doesn't exist, a new Label
            /// Permission is created, otherwise the existing permission is updated. Permissions affect the Label
            /// resource as a whole, are not revisioned, and do not require publishing.
            /// </summary>
            public class BatchUpdateRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchUpdateLabelPermissionsResponse>
            {
                /// <summary>Constructs a new BatchUpdate request.</summary>
                public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchUpdateLabelPermissionsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent Label resource name shared by all permissions being updated. Format:
                /// labels/{label} If this is set, the parent field in the UpdateLabelPermissionRequest messages must
                /// either be empty or match this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchUpdateLabelPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchUpdate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/{+parent}/permissions:batchUpdate";

                /// <summary>Initializes BatchUpdate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^labels/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Updates a Label's permissions. If a permission for the indicated principal doesn't exist, a new Label
            /// Permission is created, otherwise the existing permission is updated. Permissions affect the Label
            /// resource as a whole, are not revisioned, and do not require publishing.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent Label resource name on the Label Permission is created. Format: labels/{label}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Updates a Label's permissions. If a permission for the indicated principal doesn't exist, a new Label
            /// Permission is created, otherwise the existing permission is updated. Permissions affect the Label
            /// resource as a whole, are not revisioned, and do not require publishing.
            /// </summary>
            public class CreateRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent Label resource name on the Label Permission is created. Format: labels/{label}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an
                /// admin for the Label before allowing access.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UseAdminAccess { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/{+parent}/permissions";

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
                        Pattern = @"^labels/[^/]+$",
                    });
                    RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                    {
                        Name = "useAdminAccess",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a Label's permission. Permissions affect the Label resource as a whole, are not revisioned, and
            /// do not require publishing.
            /// </summary>
            /// <param name="name">Required. Label Permission resource name.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a Label's permission. Permissions affect the Label resource as a whole, are not revisioned, and
            /// do not require publishing.
            /// </summary>
            public class DeleteRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Label Permission resource name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an
                /// admin for the Label before allowing access.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UseAdminAccess { get; set; }

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
                        Pattern = @"^labels/[^/]+/permissions/[^/]+$",
                    });
                    RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                    {
                        Name = "useAdminAccess",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists a Label's permissions.</summary>
            /// <param name="parent">
            /// Required. The parent Label resource name on which Label Permission are listed. Format: labels/{label}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists a Label's permissions.</summary>
            public class ListRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaListLabelPermissionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent Label resource name on which Label Permission are listed. Format:
                /// labels/{label}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Maximum number of permissions to return per page. Default: 50. Max: 200.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The token of the page to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an
                /// admin for the Label before allowing access.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UseAdminAccess { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/{+parent}/permissions";

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
                        Pattern = @"^labels/[^/]+$",
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
                    RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                    {
                        Name = "useAdminAccess",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates a Label's permissions. If a permission for the indicated principal doesn't exist, a new Label
            /// Permission is created, otherwise the existing permission is updated. Permissions affect the Label
            /// resource as a whole, are not revisioned, and do not require publishing.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The parent Label resource name.</param>
            public virtual PatchRequest Patch(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission body, string parent)
            {
                return new PatchRequest(service, body, parent);
            }

            /// <summary>
            /// Updates a Label's permissions. If a permission for the indicated principal doesn't exist, a new Label
            /// Permission is created, otherwise the existing permission is updated. Permissions affect the Label
            /// resource as a whole, are not revisioned, and do not require publishing.
            /// </summary>
            public class PatchRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The parent Label resource name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an
                /// admin for the Label before allowing access.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> UseAdminAccess { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/{+parent}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^labels/[^/]+/permissions/[^/]+$",
                    });
                    RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                    {
                        Name = "useAdminAccess",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
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
                Locks = new LocksResource(service);
                Permissions = new PermissionsResource(service);
            }

            /// <summary>Gets the Locks resource.</summary>
            public virtual LocksResource Locks { get; }

            /// <summary>The "locks" collection of methods.</summary>
            public class LocksResource
            {
                private const string Resource = "locks";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public LocksResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists the Locks on a Label.</summary>
                /// <param name="parent">Required. Label on which Locks are applied. Format: labels/{label}</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists the Locks on a Label.</summary>
                public class ListRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaListLabelLocksResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Label on which Locks are applied. Format: labels/{label}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of Locks to return per page. Default: 100. Max: 200.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The token of the page to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta/{+parent}/locks";

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
                            Pattern = @"^labels/[^/]+/revisions/[^/]+$",
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

            /// <summary>Gets the Permissions resource.</summary>
            public virtual PermissionsResource Permissions { get; }

            /// <summary>The "permissions" collection of methods.</summary>
            public class PermissionsResource
            {
                private const string Resource = "permissions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PermissionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Deletes Label permissions. Permissions affect the Label resource as a whole, are not revisioned, and
                /// do not require publishing.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="labelsId"><c>null</c></param>
                /// <param name="revisionsId"><c>null</c></param>
                public virtual BatchDeleteRequest BatchDelete(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchDeleteLabelPermissionsRequest body, string labelsId, string revisionsId)
                {
                    return new BatchDeleteRequest(service, body, labelsId, revisionsId);
                }

                /// <summary>
                /// Deletes Label permissions. Permissions affect the Label resource as a whole, are not revisioned, and
                /// do not require publishing.
                /// </summary>
                public class BatchDeleteRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new BatchDelete request.</summary>
                    public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchDeleteLabelPermissionsRequest body, string labelsId, string revisionsId) : base(service)
                    {
                        LabelsId = labelsId;
                        RevisionsId = revisionsId;
                        Body = body;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("labelsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string LabelsId { get; private set; }

                    [Google.Apis.Util.RequestParameterAttribute("revisionsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string RevisionsId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchDeleteLabelPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchDelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta/labels/{labelsId}/revisions/{revisionsId}/permissions:batchDelete";

                    /// <summary>Initializes BatchDelete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("labelsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "labelsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("revisionsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "revisionsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates Label permissions. If a permission for the indicated principal doesn't exist, a new Label
                /// Permission is created, otherwise the existing permission is updated. Permissions affect the Label
                /// resource as a whole, are not revisioned, and do not require publishing.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent Label resource name shared by all permissions being updated. Format:
                /// labels/{label} If this is set, the parent field in the UpdateLabelPermissionRequest messages must
                /// either be empty or match this field.
                /// </param>
                public virtual BatchUpdateRequest BatchUpdate(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchUpdateLabelPermissionsRequest body, string parent)
                {
                    return new BatchUpdateRequest(service, body, parent);
                }

                /// <summary>
                /// Updates Label permissions. If a permission for the indicated principal doesn't exist, a new Label
                /// Permission is created, otherwise the existing permission is updated. Permissions affect the Label
                /// resource as a whole, are not revisioned, and do not require publishing.
                /// </summary>
                public class BatchUpdateRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchUpdateLabelPermissionsResponse>
                {
                    /// <summary>Constructs a new BatchUpdate request.</summary>
                    public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchUpdateLabelPermissionsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent Label resource name shared by all permissions being updated. Format:
                    /// labels/{label} If this is set, the parent field in the UpdateLabelPermissionRequest messages
                    /// must either be empty or match this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaBatchUpdateLabelPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchUpdate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta/{+parent}/permissions:batchUpdate";

                    /// <summary>Initializes BatchUpdate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^labels/[^/]+/revisions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates a Label's permissions. If a permission for the indicated principal doesn't exist, a new
                /// Label Permission is created, otherwise the existing permission is updated. Permissions affect the
                /// Label resource as a whole, are not revisioned, and do not require publishing.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent Label resource name on the Label Permission is created. Format: labels/{label}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Updates a Label's permissions. If a permission for the indicated principal doesn't exist, a new
                /// Label Permission is created, otherwise the existing permission is updated. Permissions affect the
                /// Label resource as a whole, are not revisioned, and do not require publishing.
                /// </summary>
                public class CreateRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent Label resource name on the Label Permission is created. Format:
                    /// labels/{label}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Set to `true` in order to use the user's admin credentials. The server will verify the user is
                    /// an admin for the Label before allowing access.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> UseAdminAccess { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta/{+parent}/permissions";

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
                            Pattern = @"^labels/[^/]+/revisions/[^/]+$",
                        });
                        RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                        {
                            Name = "useAdminAccess",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a Label's permission. Permissions affect the Label resource as a whole, are not revisioned,
                /// and do not require publishing.
                /// </summary>
                /// <param name="name">Required. Label Permission resource name.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a Label's permission. Permissions affect the Label resource as a whole, are not revisioned,
                /// and do not require publishing.
                /// </summary>
                public class DeleteRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Label Permission resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Set to `true` in order to use the user's admin credentials. The server will verify the user is
                    /// an admin for the Label before allowing access.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> UseAdminAccess { get; set; }

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
                            Pattern = @"^labels/[^/]+/revisions/[^/]+/permissions/[^/]+$",
                        });
                        RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                        {
                            Name = "useAdminAccess",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists a Label's permissions.</summary>
                /// <param name="parent">
                /// Required. The parent Label resource name on which Label Permission are listed. Format:
                /// labels/{label}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists a Label's permissions.</summary>
                public class ListRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaListLabelPermissionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent Label resource name on which Label Permission are listed. Format:
                    /// labels/{label}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of permissions to return per page. Default: 50. Max: 200.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The token of the page to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Set to `true` in order to use the user's admin credentials. The server will verify the user is
                    /// an admin for the Label before allowing access.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> UseAdminAccess { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta/{+parent}/permissions";

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
                            Pattern = @"^labels/[^/]+/revisions/[^/]+$",
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
                        RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                        {
                            Name = "useAdminAccess",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates a Label's permissions. If a permission for the indicated principal doesn't exist, a new
                /// Label Permission is created, otherwise the existing permission is updated. Permissions affect the
                /// Label resource as a whole, are not revisioned, and do not require publishing.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent Label resource name.</param>
                public virtual PatchRequest Patch(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission body, string parent)
                {
                    return new PatchRequest(service, body, parent);
                }

                /// <summary>
                /// Updates a Label's permissions. If a permission for the indicated principal doesn't exist, a new
                /// Label Permission is created, otherwise the existing permission is updated. Permissions affect the
                /// Label resource as a whole, are not revisioned, and do not require publishing.
                /// </summary>
                public class PatchRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent Label resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Set to `true` in order to use the user's admin credentials. The server will verify the user is
                    /// an admin for the Label before allowing access.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> UseAdminAccess { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelPermission Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta/{+parent}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^labels/[^/]+/revisions/[^/]+/permissions/[^/]+$",
                        });
                        RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                        {
                            Name = "useAdminAccess",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }
        }

        /// <summary>Creates a new Label.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabel body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a new Label.</summary>
        public class CreateRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabel>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabel body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The BCP-47 language code to use for evaluating localized Field labels in response. When not specified,
            /// values in the default configured language will be used.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Set to `true` in order to use the user's admin privileges. The server will verify the user is an admin
            /// before allowing access.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseAdminAccess { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/labels";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Permanently deletes a Label and related metadata on Drive Items. Once deleted, the Label and related Drive
        /// item metadata will be deleted. Only draft Labels, and disabled Labels may be deleted.
        /// </summary>
        /// <param name="name">Required. Label resource name.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Permanently deletes a Label and related metadata on Drive Items. Once deleted, the Label and related Drive
        /// item metadata will be deleted. Only draft Labels, and disabled Labels may be deleted.
        /// </summary>
        public class DeleteRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleProtobufEmpty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. Label resource name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an admin
            /// for the Label before allowing access.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseAdminAccess { get; set; }

            /// <summary>
            /// The revision_id of the label that the write request will be applied to. If this is not the latest
            /// revision of the label, the request will not be processed and will return a 400 Bad Request error.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("writeControl.requiredRevisionId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string WriteControlRequiredRevisionId { get; set; }

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
                    Pattern = @"^labels/[^/]+$",
                });
                RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("writeControl.requiredRevisionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "writeControl.requiredRevisionId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates a single Label by applying a set of update requests resulting in a new draft revision. The batch
        /// update is all-or-nothing: If any of the update requests are invalid, no changes are applied. The resulting
        /// draft revision must be published before the changes may be used with Drive Items.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The resource name of the Label to update.</param>
        public virtual DeltaRequest Delta(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequest body, string name)
        {
            return new DeltaRequest(service, body, name);
        }

        /// <summary>
        /// Updates a single Label by applying a set of update requests resulting in a new draft revision. The batch
        /// update is all-or-nothing: If any of the update requests are invalid, no changes are applied. The resulting
        /// draft revision must be published before the changes may be used with Drive Items.
        /// </summary>
        public class DeltaRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponse>
        {
            /// <summary>Constructs a new Delta request.</summary>
            public DeltaRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The resource name of the Label to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delta";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}:delta";

            /// <summary>Initializes Delta parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^labels/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Disable a published Label. Disabling a Label will result in a new disabled published revision based on the
        /// current published revision. If there is a draft revision, a new disabled draft revision will be created
        /// based on the latest draft revision. Older draft revisions will be deleted. Once disabled, a label may be
        /// deleted with `DeleteLabel`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. Label resource name.</param>
        public virtual DisableRequest Disable(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaDisableLabelRequest body, string name)
        {
            return new DisableRequest(service, body, name);
        }

        /// <summary>
        /// Disable a published Label. Disabling a Label will result in a new disabled published revision based on the
        /// current published revision. If there is a draft revision, a new disabled draft revision will be created
        /// based on the latest draft revision. Older draft revisions will be deleted. Once disabled, a label may be
        /// deleted with `DeleteLabel`.
        /// </summary>
        public class DisableRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabel>
        {
            /// <summary>Constructs a new Disable request.</summary>
            public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaDisableLabelRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Label resource name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaDisableLabelRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "disable";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}:disable";

            /// <summary>Initializes Disable parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^labels/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Enable a disabled Label and restore it to its published state. This will result in a new published revision
        /// based on the current disabled published revision. If there is an existing disabled draft revision, a new
        /// revision will be created based on that draft and will be enabled.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. Label resource name.</param>
        public virtual EnableRequest Enable(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaEnableLabelRequest body, string name)
        {
            return new EnableRequest(service, body, name);
        }

        /// <summary>
        /// Enable a disabled Label and restore it to its published state. This will result in a new published revision
        /// based on the current disabled published revision. If there is an existing disabled draft revision, a new
        /// revision will be created based on that draft and will be enabled.
        /// </summary>
        public class EnableRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabel>
        {
            /// <summary>Constructs a new Enable request.</summary>
            public EnableRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaEnableLabelRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Label resource name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaEnableLabelRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "enable";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}:enable";

            /// <summary>Initializes Enable parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^labels/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Get a Label by its resource name. Resource name may be any of: * `labels/{id}` - See to `labels/{id}@latest`
        /// * `labels/{id}@latest` - Gets the latest revision of the Label. * `labels/{id}@published` - Gets the current
        /// published revision of the Label. * `labels/{id}@{revision_id}` - Gets the Label at the specified revision
        /// ID.
        /// </summary>
        /// <param name="name">
        /// Required. Label resource name. May be any of: * `labels/{id}` (equivalent to labels/{id}@latest) *
        /// `labels/{id}@latest` * `labels/{id}@published` * `labels/{id}@{revision_id}`
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Get a Label by its resource name. Resource name may be any of: * `labels/{id}` - See to `labels/{id}@latest`
        /// * `labels/{id}@latest` - Gets the latest revision of the Label. * `labels/{id}@published` - Gets the current
        /// published revision of the Label. * `labels/{id}@{revision_id}` - Gets the Label at the specified revision
        /// ID.
        /// </summary>
        public class GetRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabel>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Label resource name. May be any of: * `labels/{id}` (equivalent to labels/{id}@latest) *
            /// `labels/{id}@latest` * `labels/{id}@published` * `labels/{id}@{revision_id}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The BCP-47 language code to use for evaluating localized Field labels. When not specified, values in the
            /// default configured language will be used.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an admin
            /// for the Label before allowing access.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseAdminAccess { get; set; }

            /// <summary>When specified, only certain Fields belonging to the indicated view will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>When specified, only certain Fields belonging to the indicated view will be returned.</summary>
            public enum ViewEnum
            {
                /// <summary>Implies the field mask: `name,id,revision_id,label_type,properties.*`</summary>
                [Google.Apis.Util.StringValueAttribute("LABEL_VIEW_BASIC")]
                LABELVIEWBASIC = 0,

                /// <summary>All possible fields.</summary>
                [Google.Apis.Util.StringValueAttribute("LABEL_VIEW_FULL")]
                LABELVIEWFULL = 1,
            }

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
                    Pattern = @"^labels/[^/]+$",
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// -------------------------------------------------------------------------- ## Label APIs
        /// --------------------------------------------------------------- List Labels.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// -------------------------------------------------------------------------- ## Label APIs
        /// --------------------------------------------------------------- List Labels.
        /// </summary>
        public class ListRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaListLabelsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The BCP-47 language code to use for evaluating localized field labels. When not specified, values in the
            /// default configured language will be used.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Specifies the level of access the user must have on the returned Labels. The minimum role a user must
            /// have on a label. Defaults to `READER`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("minimumRole", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<MinimumRoleEnum> MinimumRole { get; set; }

            /// <summary>
            /// Specifies the level of access the user must have on the returned Labels. The minimum role a user must
            /// have on a label. Defaults to `READER`.
            /// </summary>
            public enum MinimumRoleEnum
            {
                /// <summary>Unknown role.</summary>
                [Google.Apis.Util.StringValueAttribute("LABEL_ROLE_UNSPECIFIED")]
                LABELROLEUNSPECIFIED = 0,

                /// <summary>A reader can read the Label and associated metadata applied to Drive items.</summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary>
                /// An applier can write associated metadata on Drive items in which they also have write access to.
                /// Implies `READER`.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("APPLIER")]
                APPLIER = 2,

                /// <summary>
                /// An organizer is allowed to pin this label in shared drives they manage and add new appliers to the
                /// label.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("ORGANIZER")]
                ORGANIZER = 3,

                /// <summary>
                /// Editors may make any updates including deleting the Label which will also delete associated Drive
                /// item metadata. Implies `APPLIER`.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("EDITOR")]
                EDITOR = 4,
            }

            /// <summary>Maximum number of Labels to return per page. Default: 50. Max: 200.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The token of the page to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Whether to include only published labels in the results. * When `true`, only the current published label
            /// revisions will be returned. Disabled labels will be included. Returned Label resource names will
            /// reference the published revision (`labels/{id}/{revision_id}`). * When `false`, the current label
            /// revisions will be returned, which may not by published. Returned Label resource names will not reference
            /// a specific revision (`labels/{id}`).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("publishedOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PublishedOnly { get; set; }

            /// <summary>
            /// Set to `true` in order to use the user's admin credentials. This will return all Labels within the
            /// customer.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseAdminAccess { get; set; }

            /// <summary>When specified, only certain fields belonging to the indicated view will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>When specified, only certain fields belonging to the indicated view will be returned.</summary>
            public enum ViewEnum
            {
                /// <summary>Implies the field mask: `name,id,revision_id,label_type,properties.*`</summary>
                [Google.Apis.Util.StringValueAttribute("LABEL_VIEW_BASIC")]
                LABELVIEWBASIC = 0,

                /// <summary>All possible fields.</summary>
                [Google.Apis.Util.StringValueAttribute("LABEL_VIEW_FULL")]
                LABELVIEWFULL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/labels";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("minimumRole", new Google.Apis.Discovery.Parameter
                {
                    Name = "minimumRole",
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
                RequestParameters.Add("publishedOnly", new Google.Apis.Discovery.Parameter
                {
                    Name = "publishedOnly",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useAdminAccess",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Publish all draft changes to the Label. Once published, the Label may not return to its draft state. See
        /// `google.apps.drive.labels.v2.Lifecycle` for more information. Publishing a Label will result in a new
        /// published revision. All previous draft revisions will be deleted. Previous published revisions will be kept
        /// but are subject to automated deletion as needed. Once published, some changes are no longer permitted.
        /// Generally, any change that would invalidate or cause new restrictions on existing metadata related to the
        /// Label will be rejected. For example, the following changes to a Label will be rejected after the Label is
        /// published: * The label cannot be directly deleted. It must be disabled first, then deleted. *
        /// Field.FieldType cannot be changed. * Changes to Field validation options cannot reject something that was
        /// previously accepted. * Reducing the max entries.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. Label resource name.</param>
        public virtual PublishRequest Publish(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaPublishLabelRequest body, string name)
        {
            return new PublishRequest(service, body, name);
        }

        /// <summary>
        /// Publish all draft changes to the Label. Once published, the Label may not return to its draft state. See
        /// `google.apps.drive.labels.v2.Lifecycle` for more information. Publishing a Label will result in a new
        /// published revision. All previous draft revisions will be deleted. Previous published revisions will be kept
        /// but are subject to automated deletion as needed. Once published, some changes are no longer permitted.
        /// Generally, any change that would invalidate or cause new restrictions on existing metadata related to the
        /// Label will be rejected. For example, the following changes to a Label will be rejected after the Label is
        /// published: * The label cannot be directly deleted. It must be disabled first, then deleted. *
        /// Field.FieldType cannot be changed. * Changes to Field validation options cannot reject something that was
        /// previously accepted. * Reducing the max entries.
        /// </summary>
        public class PublishRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabel>
        {
            /// <summary>Constructs a new Publish request.</summary>
            public PublishRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaPublishLabelRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Label resource name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaPublishLabelRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "publish";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}:publish";

            /// <summary>Initializes Publish parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^labels/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Updates a Label's `CopyMode`. Changes to this policy are not revisioned, do not require publishing, and take
        /// effect immediately.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The resource name of the Label to update.</param>
        public virtual UpdateLabelCopyModeRequest UpdateLabelCopyMode(Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaUpdateLabelCopyModeRequest body, string name)
        {
            return new UpdateLabelCopyModeRequest(service, body, name);
        }

        /// <summary>
        /// Updates a Label's `CopyMode`. Changes to this policy are not revisioned, do not require publishing, and take
        /// effect immediately.
        /// </summary>
        public class UpdateLabelCopyModeRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabel>
        {
            /// <summary>Constructs a new UpdateLabelCopyMode request.</summary>
            public UpdateLabelCopyModeRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaUpdateLabelCopyModeRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The resource name of the Label to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaUpdateLabelCopyModeRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateLabelCopyMode";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}:updateLabelCopyMode";

            /// <summary>Initializes UpdateLabelCopyMode parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^labels/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "limits" collection of methods.</summary>
    public class LimitsResource
    {
        private const string Resource = "limits";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LimitsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Get the constraints on the structure of a Label; such as, the maximum number of Fields allowed and maximum
        /// length of the label title.
        /// </summary>
        public virtual GetLabelRequest GetLabel()
        {
            return new GetLabelRequest(service);
        }

        /// <summary>
        /// Get the constraints on the structure of a Label; such as, the maximum number of Fields allowed and maximum
        /// length of the label title.
        /// </summary>
        public class GetLabelRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaLabelLimits>
        {
            /// <summary>Constructs a new GetLabel request.</summary>
            public GetLabelRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Required. Label revision resource name Must be: "limits/label"</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Name { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getLabel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/limits/label";

            /// <summary>Initializes GetLabel parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "users" collection of methods.</summary>
    public class UsersResource
    {
        private const string Resource = "users";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UsersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the user capabilities.</summary>
        /// <param name="name">
        /// Required. The resource name of the user. Only "users/me/capabilities" is supported.
        /// </param>
        public virtual GetCapabilitiesRequest GetCapabilities(string name)
        {
            return new GetCapabilitiesRequest(service, name);
        }

        /// <summary>Gets the user capabilities.</summary>
        public class GetCapabilitiesRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2beta.Data.GoogleAppsDriveLabelsV2betaUserCapabilities>
        {
            /// <summary>Constructs a new GetCapabilities request.</summary>
            public GetCapabilitiesRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The resource name of the user. Only "users/me/capabilities" is supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getCapabilities";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}";

            /// <summary>Initializes GetCapabilities parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^users/[^/]+/capabilities$",
                });
            }
        }
    }
}
namespace Google.Apis.DriveLabels.v2beta.Data
{
    /// <summary>The color derived from BadgeConfig and coerced to the nearest supported color.</summary>
    public class GoogleAppsDriveLabelsV2betaBadgeColors : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Badge background which pairs with the foreground</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual GoogleTypeColor BackgroundColor { get; set; }

        /// <summary>Output only. Badge foreground which pairs with the background</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foregroundColor")]
        public virtual GoogleTypeColor ForegroundColor { get; set; }

        /// <summary>Output only. Color that can be used for text without a background</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("soloColor")]
        public virtual GoogleTypeColor SoloColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Badge status of the label.</summary>
    public class GoogleAppsDriveLabelsV2betaBadgeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The color of the badge. When not specified, no badge will be rendered. This color will be coerced into the
        /// closest recommended supported color.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual GoogleTypeColor Color { get; set; }

        /// <summary>
        /// Override the default global priority of this badge. When set to 0, the default priority heuristic will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priorityOverride")]
        public virtual System.Nullable<long> PriorityOverride { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes one of more Label Permissions.</summary>
    public class GoogleAppsDriveLabelsV2betaBatchDeleteLabelPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The request message specifying the resources to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2betaDeleteLabelPermissionRequest> Requests { get; set; }

        /// <summary>
        /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an admin for
        /// the Label before allowing access. If this is set, the use_admin_access field in the
        /// DeleteLabelPermissionRequest messages must either be empty or match this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAdminAccess")]
        public virtual System.Nullable<bool> UseAdminAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates one or more Label Permissions.</summary>
    public class GoogleAppsDriveLabelsV2betaBatchUpdateLabelPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The request message specifying the resources to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2betaUpdateLabelPermissionRequest> Requests { get; set; }

        /// <summary>
        /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an admin for
        /// the Label before allowing access. If this is set, the use_admin_access field in the
        /// UpdateLabelPermissionRequest messages must either be empty or match this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAdminAccess")]
        public virtual System.Nullable<bool> UseAdminAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for updating one or more Label Permissions.</summary>
    public class GoogleAppsDriveLabelsV2betaBatchUpdateLabelPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Permissions updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2betaLabelPermission> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Limits for date Field type.</summary>
    public class GoogleAppsDriveLabelsV2betaDateLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum value for the date Field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual GoogleTypeDate MaxValue { get; set; }

        /// <summary>Minimum value for the date Field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual GoogleTypeDate MinValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deletes a Label Permission. Permissions affect the Label resource as a whole, are not revisioned, and do not
    /// require publishing.
    /// </summary>
    public class GoogleAppsDriveLabelsV2betaDeleteLabelPermissionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Label Permission resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an admin for
        /// the Label before allowing access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAdminAccess")]
        public virtual System.Nullable<bool> UseAdminAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The set of requests for updating aspects of a Label. If any request is not valid, no requests will be applied.
    /// </summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The BCP-47 language code to use for evaluating localized Field labels when `include_label_in_response` is
        /// `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// A list of updates to apply to the Label. Requests will be applied in the order they are specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestRequest> Requests { get; set; }

        /// <summary>
        /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an admin for
        /// the Label before allowing access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAdminAccess")]
        public virtual System.Nullable<bool> UseAdminAccess { get; set; }

        /// <summary>When specified, only certain fields belonging to the indicated view will be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("view")]
        public virtual string View { get; set; }

        /// <summary>Provides control over how write requests are executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeControl")]
        public virtual GoogleAppsDriveLabelsV2betaWriteControl WriteControl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create a Field within a Label.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestCreateFieldRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Field to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual GoogleAppsDriveLabelsV2betaField Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create a Selection Choice.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestCreateSelectionChoiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Choice to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("choice")]
        public virtual GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoice Choice { get; set; }

        /// <summary>Required. The Selection Field in which a Choice will be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to delete the Field.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestDeleteFieldRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the Field to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to delete a Choice.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestDeleteSelectionChoiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Selection Field from which a Choice will be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; }

        /// <summary>Required. Choice to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to disable the Field.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestDisableFieldRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Field Disabled Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabledPolicy")]
        public virtual GoogleAppsDriveLabelsV2betaLifecycleDisabledPolicy DisabledPolicy { get; set; }

        /// <summary>Required. Key of the Field to disable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `disabled_policy` is
        /// implied and should not be specified. A single `*` can be used as short-hand for updating every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to disable a Choice.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestDisableSelectionChoiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The disabled policy to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabledPolicy")]
        public virtual GoogleAppsDriveLabelsV2betaLifecycleDisabledPolicy DisabledPolicy { get; set; }

        /// <summary>Required. The Selection Field in which a Choice will be disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; }

        /// <summary>Required. Choice to disable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `disabled_policy` is
        /// implied and should not be specified. A single `*` can be used as short-hand for updating every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to enable the Field.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestEnableFieldRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the Field to enable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to enable a Choice.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestEnableSelectionChoiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Selection Field in which a Choice will be enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; }

        /// <summary>Required. Choice to enable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single kind of update to apply to a Label.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creates a new Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createField")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestCreateFieldRequest CreateField { get; set; }

        /// <summary>Creates Choice within a Selection field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSelectionChoice")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestCreateSelectionChoiceRequest CreateSelectionChoice { get; set; }

        /// <summary>Deletes a Field from the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteField")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestDeleteFieldRequest DeleteField { get; set; }

        /// <summary>Delete a Choice within a Selection Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteSelectionChoice")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestDeleteSelectionChoiceRequest DeleteSelectionChoice { get; set; }

        /// <summary>Disables the Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableField")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestDisableFieldRequest DisableField { get; set; }

        /// <summary>Disable a Choice within a Selection Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableSelectionChoice")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestDisableSelectionChoiceRequest DisableSelectionChoice { get; set; }

        /// <summary>Enables the Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableField")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestEnableFieldRequest EnableField { get; set; }

        /// <summary>Enable a Choice within a Selection Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSelectionChoice")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestEnableSelectionChoiceRequest EnableSelectionChoice { get; set; }

        /// <summary>Updates basic properties of a Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateField")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestUpdateFieldPropertiesRequest UpdateField { get; set; }

        /// <summary>Update Field type and/or type options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateFieldType")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestUpdateFieldTypeRequest UpdateFieldType { get; set; }

        /// <summary>Updates the Label properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateLabel")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestUpdateLabelPropertiesRequest UpdateLabel { get; set; }

        /// <summary>Update a Choice properties within a Selection Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateSelectionChoiceProperties")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestUpdateSelectionChoicePropertiesRequest UpdateSelectionChoiceProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to update Field properties.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestUpdateFieldPropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Field to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. Basic Field properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoogleAppsDriveLabelsV2betaFieldProperties Properties { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `properties` is implied
        /// and should not be specified. A single `*` can be used as short-hand for updating every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to change the type of a Field.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestUpdateFieldTypeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Update field to Date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldDateOptions DateOptions { get; set; }

        /// <summary>Required. The Field to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Update field to Integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldIntegerOptions IntegerOptions { get; set; }

        /// <summary>Update field to Long Text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longTextOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldLongTextOptions LongTextOptions { get; set; }

        /// <summary>Update field to Selection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldSelectionOptions SelectionOptions { get; set; }

        /// <summary>Update field to Text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldTextOptions TextOptions { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root of `type_options` is
        /// implied and should not be specified. A single `*` can be used as short-hand for updating every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>Update field to User.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldUserOptions UserOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates basic properties of a Label.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestUpdateLabelPropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Label properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoogleAppsDriveLabelsV2betaLabelProperties Properties { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `label_properties` is
        /// implied and should not be specified. A single `*` can be used as short-hand for updating every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to update a Choice properties.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelRequestUpdateSelectionChoicePropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Selection Field to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; }

        /// <summary>Required. The Choice to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. The Choice properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoiceProperties Properties { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `properties` is implied
        /// and should not be specified. A single `*` can be used as short-hand for updating every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for Label update.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reply of the updates. This maps 1:1 with the updates, although responses to some requests may be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseResponse> Responses { get; set; }

        /// <summary>
        /// The label after updates were applied. This is only set if
        /// [BatchUpdateLabelResponse2.include_label_in_response] is `true` and there were no errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedLabel")]
        public virtual GoogleAppsDriveLabelsV2betaLabel UpdatedLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following Field create.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseCreateFieldResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The field of the created field. When left blank in a create request, a key will be autogenerated and can be
        /// identified here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The priority of the created field. The priority may change from what was specified to assure contiguous
        /// priorities between fields (1-n).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following Selection Choice create.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseCreateSelectionChoiceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The server-generated id of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; }

        /// <summary>The server-generated ID of the created choice within the Field</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following Field delete.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseDeleteFieldResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following Choice delete.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseDeleteSelectionChoiceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following Field disable.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseDisableFieldResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following Choice disable.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseDisableSelectionChoiceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following Field enable.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseEnableFieldResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following Choice enable.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseEnableSelectionChoiceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single response from an update.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creates a new Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createField")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseCreateFieldResponse CreateField { get; set; }

        /// <summary>Creates a new selection list option to add to a Selection Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSelectionChoice")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseCreateSelectionChoiceResponse CreateSelectionChoice { get; set; }

        /// <summary>Deletes a Field from the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteField")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseDeleteFieldResponse DeleteField { get; set; }

        /// <summary>Deletes a Choice from a Selection Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteSelectionChoice")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseDeleteSelectionChoiceResponse DeleteSelectionChoice { get; set; }

        /// <summary>Disables Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableField")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseDisableFieldResponse DisableField { get; set; }

        /// <summary>Disables a Choice within a Selection Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableSelectionChoice")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseDisableSelectionChoiceResponse DisableSelectionChoice { get; set; }

        /// <summary>Enables Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableField")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseEnableFieldResponse EnableField { get; set; }

        /// <summary>Enables a Choice within a Selection Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSelectionChoice")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseEnableSelectionChoiceResponse EnableSelectionChoice { get; set; }

        /// <summary>Updates basic properties of a Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateField")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseUpdateFieldPropertiesResponse UpdateField { get; set; }

        /// <summary>Update Field type and/or type options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateFieldType")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseUpdateFieldTypeResponse UpdateFieldType { get; set; }

        /// <summary>Updated basic properties of a Label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateLabel")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseUpdateLabelPropertiesResponse UpdateLabel { get; set; }

        /// <summary>Updates a Choice within a Selection Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateSelectionChoiceProperties")]
        public virtual GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseUpdateSelectionChoicePropertiesResponse UpdateSelectionChoiceProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following update to Field properties.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseUpdateFieldPropertiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The priority of the updated field. The priority may change from what was specified to assure contiguous
        /// priorities between fields (1-n).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following update to Field type.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseUpdateFieldTypeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following update to Label properties.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseUpdateLabelPropertiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response following update to Selection Choice properties.</summary>
    public class GoogleAppsDriveLabelsV2betaDeltaUpdateLabelResponseUpdateSelectionChoicePropertiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The priority of the updated choice. The priority may change from what was specified to assure contiguous
        /// priorities between choices (1-n).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to deprecate a published Label.</summary>
    public class GoogleAppsDriveLabelsV2betaDisableLabelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Disabled policy to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabledPolicy")]
        public virtual GoogleAppsDriveLabelsV2betaLifecycleDisabledPolicy DisabledPolicy { get; set; }

        /// <summary>
        /// The BCP-47 language code to use for evaluating localized field labels. When not specified, values in the
        /// default configured language will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `disabled_policy` is
        /// implied and should not be specified. A single `*` can be used as short-hand for updating every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>
        /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an admin for
        /// the Label before allowing access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAdminAccess")]
        public virtual System.Nullable<bool> UseAdminAccess { get; set; }

        /// <summary>
        /// Provides control over how write requests are executed. Defaults to unset, which means last write wins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeControl")]
        public virtual GoogleAppsDriveLabelsV2betaWriteControl WriteControl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to enable a label.</summary>
    public class GoogleAppsDriveLabelsV2betaEnableLabelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The BCP-47 language code to use for evaluating localized field labels. When not specified, values in the
        /// default configured language will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an admin for
        /// the Label before allowing access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAdminAccess")]
        public virtual System.Nullable<bool> UseAdminAccess { get; set; }

        /// <summary>
        /// Provides control over how write requests are executed. Defaults to unset, which means last write wins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeControl")]
        public virtual GoogleAppsDriveLabelsV2betaWriteControl WriteControl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a field which has a display name, data type, and other configuration options. This field defines the
    /// kind of metadata that may be set on a Drive item.
    /// </summary>
    public class GoogleAppsDriveLabelsV2betaField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The capabilities this user has on this Field and its value when the Label is applied on Drive
        /// items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedCapabilities")]
        public virtual GoogleAppsDriveLabelsV2betaFieldAppliedCapabilities AppliedCapabilities { get; set; }

        /// <summary>Output only. The time this field was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The user who created this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Creator { get; set; }

        /// <summary>Date field options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldDateOptions DateOptions { get; set; }

        /// <summary>
        /// Output only. The time this field was disabled. This value has no meaning when the field is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTime")]
        public virtual object DisableTime { get; set; }

        /// <summary>
        /// Output only. The user who disabled this field. This value has no meaning when the field is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabler")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Disabler { get; set; }

        /// <summary>Output only. UI Display hints for rendering a Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayHints")]
        public virtual GoogleAppsDriveLabelsV2betaFieldDisplayHints DisplayHints { get; set; }

        /// <summary>
        /// Output only. The key of a field, unique within a Label or Library. This value is autogenerated, and will
        /// match the form `([a-zA-Z0-9_])+
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Integer field options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldIntegerOptions IntegerOptions { get; set; }

        /// <summary>Output only. The lifecycle of this Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycle")]
        public virtual GoogleAppsDriveLabelsV2betaLifecycle Lifecycle { get; set; }

        /// <summary>Output only. The LockStatus of this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockStatus")]
        public virtual GoogleAppsDriveLabelsV2betaLockStatus LockStatus { get; set; }

        /// <summary>The basic properties of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoogleAppsDriveLabelsV2betaFieldProperties Properties { get; set; }

        /// <summary>
        /// Output only. The user who published this field. This value has no meaning when the field is not published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Publisher { get; set; }

        /// <summary>
        /// Output only. The key to use when constructing Drive search queries to find files based on values defined for
        /// this Field on files. For example: "`{query_key}` &amp;gt; 2001-01-01"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryKey")]
        public virtual string QueryKey { get; set; }

        /// <summary>Output only. The capabilities this user has when editing this Field</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaCapabilities")]
        public virtual GoogleAppsDriveLabelsV2betaFieldSchemaCapabilities SchemaCapabilities { get; set; }

        /// <summary>Selection field options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldSelectionOptions SelectionOptions { get; set; }

        /// <summary>Text field options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldTextOptions TextOptions { get; set; }

        /// <summary>Output only. The time this field was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Output only. The user who modified this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updater")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Updater { get; set; }

        /// <summary>User field options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldUserOptions UserOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities related to this field on applied metadata.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldAppliedCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the user can read related applied metadata on items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canRead")]
        public virtual System.Nullable<bool> CanRead { get; set; }

        /// <summary>Whether the user can search for drive items referencing this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canSearch")]
        public virtual System.Nullable<bool> CanSearch { get; set; }

        /// <summary>Whether the user can set this field on drive items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canWrite")]
        public virtual System.Nullable<bool> CanWrite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the date field type.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldDateOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. ICU Date format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateFormat")]
        public virtual string DateFormat { get; set; }

        /// <summary>
        /// Localized date formatting option. Field values will be rendered in this format according to their locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateFormatType")]
        public virtual string DateFormatType { get; set; }

        /// <summary>Output only. Maximum valid value (year, month, day).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual GoogleTypeDate MaxValue { get; set; }

        /// <summary>Output only. Minimum valid value (year, month, day).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual GoogleTypeDate MinValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UI Display hints for rendering a Field.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldDisplayHints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the field should be shown in the UI as disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>This Field should be hidden in the search menu.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenInSearch")]
        public virtual System.Nullable<bool> HiddenInSearch { get; set; }

        /// <summary>Whether the Field should be shown as required in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; }

        /// <summary>This Field should be shown when applying values to a Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shownInApply")]
        public virtual System.Nullable<bool> ShownInApply { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the Integer field type.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldIntegerOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The maximum valid value for the integer field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<long> MaxValue { get; set; }

        /// <summary>Output only. The minimum valid value for the integer field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<long> MinValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Field constants governing the structure of a Field; such as, the maximum title length, minimum and maximum field
    /// values or length, etc.
    /// </summary>
    public class GoogleAppsDriveLabelsV2betaFieldLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Date Field limits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateLimits")]
        public virtual GoogleAppsDriveLabelsV2betaDateLimits DateLimits { get; set; }

        /// <summary>Integer Field limits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerLimits")]
        public virtual GoogleAppsDriveLabelsV2betaIntegerLimits IntegerLimits { get; set; }

        /// <summary>Long text Field limits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longTextLimits")]
        public virtual GoogleAppsDriveLabelsV2betaLongTextLimits LongTextLimits { get; set; }

        /// <summary>Limits for Field description, also called help text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDescriptionLength")]
        public virtual System.Nullable<int> MaxDescriptionLength { get; set; }

        /// <summary>Limits for Field title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDisplayNameLength")]
        public virtual System.Nullable<int> MaxDisplayNameLength { get; set; }

        /// <summary>Max length for the id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIdLength")]
        public virtual System.Nullable<int> MaxIdLength { get; set; }

        /// <summary>Selection Field limits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionLimits")]
        public virtual GoogleAppsDriveLabelsV2betaSelectionLimits SelectionLimits { get; set; }

        /// <summary>The relevant limits for the specified Field.Type. Text Field limits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textLimits")]
        public virtual GoogleAppsDriveLabelsV2betaTextLimits TextLimits { get; set; }

        /// <summary>User Field limits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLimits")]
        public virtual GoogleAppsDriveLabelsV2betaUserLimits UserLimits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for a multi-valued variant of an associated field type.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldListOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum number of entries permitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxEntries")]
        public virtual System.Nullable<int> MaxEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options the Long Text field type.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldLongTextOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The maximum valid length of values for the text field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLength")]
        public virtual System.Nullable<int> MaxLength { get; set; }

        /// <summary>Output only. The minimum valid length of values for the text field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minLength")]
        public virtual System.Nullable<int> MinLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The basic properties of the field.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The display text to show in the UI identifying this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Input only. Insert or move this Field to be ordered before the indicated Field. If empty, the Field will be
        /// placed at the end of the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertBeforeField")]
        public virtual string InsertBeforeField { get; set; }

        /// <summary>Whether the field should be marked as required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities related to this Field when editing the Field.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldSchemaCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the user can delete this Field. The user must have permissions and the Field must be deprecated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDelete")]
        public virtual System.Nullable<bool> CanDelete { get; set; }

        /// <summary>
        /// Whether the user can disable this Field. The user must have permissions and this Field must not already be
        /// disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDisable")]
        public virtual System.Nullable<bool> CanDisable { get; set; }

        /// <summary>
        /// Whether the user can enable this Field. The user must have permissions and this Field must be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canEnable")]
        public virtual System.Nullable<bool> CanEnable { get; set; }

        /// <summary>Whether the user can change this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canUpdate")]
        public virtual System.Nullable<bool> CanUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the selection field type.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldSelectionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The options available for this selection field. The list order is consistent, and modified with
        /// `insert_before_choice`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("choices")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoice> Choices { get; set; }

        /// <summary>
        /// When specified, indicates that this field support a list of values. Once the field is published, this cannot
        /// be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldListOptions ListOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Selection field Choice.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The capabilities related to this Choice on applied metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedCapabilities")]
        public virtual GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoiceAppliedCapabilities AppliedCapabilities { get; set; }

        /// <summary>Output only. The time this Choice was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The user who created this Choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Creator { get; set; }

        /// <summary>
        /// Output only. The time this Choice was disabled. This value has no meaning when the Choice is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTime")]
        public virtual object DisableTime { get; set; }

        /// <summary>
        /// Output only. The user who disabled this Choice. This value has no meaning when the option is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabler")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Disabler { get; set; }

        /// <summary>Output only. UI Display hints for rendering a Choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayHints")]
        public virtual GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoiceDisplayHints DisplayHints { get; set; }

        /// <summary>
        /// The unique value of the Choice. This ID will be autogenerated, and will match the form `([a-zA-Z0-9_])+`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Lifecycle of the Choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycle")]
        public virtual GoogleAppsDriveLabelsV2betaLifecycle Lifecycle { get; set; }

        /// <summary>Output only. The LockStatus of this Choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockStatus")]
        public virtual GoogleAppsDriveLabelsV2betaLockStatus LockStatus { get; set; }

        /// <summary>Basic properties of the Choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoiceProperties Properties { get; set; }

        /// <summary>
        /// Output only. The time this Choice was published. This value has no meaning when the Choice is not published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual object PublishTime { get; set; }

        /// <summary>
        /// Output only. The user who published this Choice. This value has no meaning when the Choice is not published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Publisher { get; set; }

        /// <summary>Output only. The capabilities related to this option when editing the option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaCapabilities")]
        public virtual GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoiceSchemaCapabilities SchemaCapabilities { get; set; }

        /// <summary>Output only. The time this Choice was updated last.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Output only. The user who updated this Choice last.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updater")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Updater { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities related to this Choice on applied metadata.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoiceAppliedCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the user can read related applied metadata on items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canRead")]
        public virtual System.Nullable<bool> CanRead { get; set; }

        /// <summary>Whether the user can use this Choice in search queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canSearch")]
        public virtual System.Nullable<bool> CanSearch { get; set; }

        /// <summary>Whether the user can select this Choice on an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canSelect")]
        public virtual System.Nullable<bool> CanSelect { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UI Display hints for rendering a Option.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoiceDisplayHints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The colors to use for the badge. Coerced to Google Material colors based on the chosen
        /// `properties.badge_config.color`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badgeColors")]
        public virtual GoogleAppsDriveLabelsV2betaBadgeColors BadgeColors { get; set; }

        /// <summary>
        /// The priority of this badge, used to compare and sort between multiple badges. A lower number means that the
        /// badge should be shown first. When a badging configuration is not present, this will be 0. Otherwise, this
        /// will be set to `BadgeConfig.priority_override` or the default heuristic which prefers creation date of the
        /// Label, and field and option priority.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badgePriority")]
        public virtual System.Nullable<long> BadgePriority { get; set; }

        /// <summary>
        /// The dark-mode color to use for the badge. Coerced to Google Material colors based on the chosen
        /// `properties.badge_config.color`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("darkBadgeColors")]
        public virtual GoogleAppsDriveLabelsV2betaBadgeColors DarkBadgeColors { get; set; }

        /// <summary>Whether the option should be shown in the UI as disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>This option should be hidden in the search menu.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenInSearch")]
        public virtual System.Nullable<bool> HiddenInSearch { get; set; }

        /// <summary>This option should be shown in the menu when applying values to a Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shownInApply")]
        public virtual System.Nullable<bool> ShownInApply { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic properties of the Choice.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoiceProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The badge configuration for this Choice. When set, the Label that owns this Choice will be considered a
        /// "badged label".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badgeConfig")]
        public virtual GoogleAppsDriveLabelsV2betaBadgeConfig BadgeConfig { get; set; }

        /// <summary>The description of this Label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display text to show in the UI identifying this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Input only. Insert or move this Choice to be ordered before the indicated Choice. If empty, the Choice will
        /// be placed at the end of the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertBeforeChoice")]
        public virtual string InsertBeforeChoice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities related to this Choice when editing the Choice.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldSelectionOptionsChoiceSchemaCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the user can delete this Choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDelete")]
        public virtual System.Nullable<bool> CanDelete { get; set; }

        /// <summary>Whether the user can disable this Chioce.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDisable")]
        public virtual System.Nullable<bool> CanDisable { get; set; }

        /// <summary>Whether the user can enable this Choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canEnable")]
        public virtual System.Nullable<bool> CanEnable { get; set; }

        /// <summary>Whether the user can update this Choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canUpdate")]
        public virtual System.Nullable<bool> CanUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the Text field type.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldTextOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The maximum valid length of values for the text field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLength")]
        public virtual System.Nullable<int> MaxLength { get; set; }

        /// <summary>Output only. The minimum valid length of values for the text field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minLength")]
        public virtual System.Nullable<int> MinLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the user field type.</summary>
    public class GoogleAppsDriveLabelsV2betaFieldUserOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When specified, indicates that this field support a list of values. Once the field is published, this cannot
        /// be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listOptions")]
        public virtual GoogleAppsDriveLabelsV2betaFieldListOptions ListOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Limits for integer Field type.</summary>
    public class GoogleAppsDriveLabelsV2betaIntegerLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum value for an integer Field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<long> MaxValue { get; set; }

        /// <summary>Minimum value for an integer Field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<long> MinValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Label defines a taxonomy which may be applied to a Drive items in order to organize and search across Items.
    /// Labels may be simple strings, or may contain Fields that describe additional metadata which can be further used
    /// to organize and search Drive items.
    /// </summary>
    public class GoogleAppsDriveLabelsV2betaLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The capabilities related to this label on applied metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedCapabilities")]
        public virtual GoogleAppsDriveLabelsV2betaLabelAppliedCapabilities AppliedCapabilities { get; set; }

        /// <summary>Output only. Behavior of this Label when its applied to Drive items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedLabelPolicy")]
        public virtual GoogleAppsDriveLabelsV2betaLabelAppliedLabelPolicy AppliedLabelPolicy { get; set; }

        /// <summary>Output only. The time this label was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The user who created this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Creator { get; set; }

        /// <summary>
        /// Output only. The time this label was disabled. This value has no meaning when the label is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTime")]
        public virtual object DisableTime { get; set; }

        /// <summary>
        /// Output only. The user who disabled this label. This value has no meaning when the label is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabler")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Disabler { get; set; }

        /// <summary>Output only. UI Display hints for rendering the Label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayHints")]
        public virtual GoogleAppsDriveLabelsV2betaLabelDisplayHints DisplayHints { get; set; }

        /// <summary>List of Fields in descending priority order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2betaField> Fields { get; set; }

        /// <summary>
        /// Output only. Globally unique identifier of this Label. ID makes up part of the Label `name`, but unlike
        /// `name`, ID is consistent between revisions. Matches the regex: `([a-zA-Z0-9])+`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. The type of this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelType")]
        public virtual string LabelType { get; set; }

        /// <summary>
        /// Custom URL to present to users to allow them to learn more about this label and how it should be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("learnMoreUri")]
        public virtual string LearnMoreUri { get; set; }

        /// <summary>
        /// Output only. The lifecycle state of the label including whether it's published, deprecated, and has draft
        /// changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycle")]
        public virtual GoogleAppsDriveLabelsV2betaLifecycle Lifecycle { get; set; }

        /// <summary>Output only. The LockStatus of this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockStatus")]
        public virtual GoogleAppsDriveLabelsV2betaLockStatus LockStatus { get; set; }

        /// <summary>
        /// Output only. Resource name of the Label. Will be in the form of either: `labels/{id}` or
        /// `labels/{id}@{revision_id}` depending on the request. See `id` and `revision_id` below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The basic properties of the Label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoogleAppsDriveLabelsV2betaLabelProperties Properties { get; set; }

        /// <summary>
        /// Output only. The time this label was published. This value has no meaning when the label is not published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual object PublishTime { get; set; }

        /// <summary>
        /// Output only. The user who published this label. This value has no meaning when the label is not published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Publisher { get; set; }

        /// <summary>Output only. The time this label revision was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreateTime")]
        public virtual object RevisionCreateTime { get; set; }

        /// <summary>Output only. The user who created this label revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreator")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo RevisionCreator { get; set; }

        /// <summary>
        /// Output only. Revision ID of the Label. Revision ID may be part of the Label `name` depending on the request
        /// issued. A new revision is created whenever revisioned properties of a Label are changed. Matches the regex:
        /// `([a-zA-Z0-9])+`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Output only. The capabilities the user has on this Label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaCapabilities")]
        public virtual GoogleAppsDriveLabelsV2betaLabelSchemaCapabilities SchemaCapabilities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities a user has on this Label's applied metadata.</summary>
    public class GoogleAppsDriveLabelsV2betaLabelAppliedCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the user can apply this Label to items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canApply")]
        public virtual System.Nullable<bool> CanApply { get; set; }

        /// <summary>Whether the user can read applied metadata related to this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canRead")]
        public virtual System.Nullable<bool> CanRead { get; set; }

        /// <summary>Whether the user can remove this Label from items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canRemove")]
        public virtual System.Nullable<bool> CanRemove { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Behavior of this Label when its applied to Drive items.</summary>
    public class GoogleAppsDriveLabelsV2betaLabelAppliedLabelPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates how the applied Label, and Field values should be copied when a Drive item is copied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyMode")]
        public virtual string CopyMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UI Display hints for rendering the Label.</summary>
    public class GoogleAppsDriveLabelsV2betaLabelDisplayHints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the Label should be shown in the UI as disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>This Label should be hidden in the search menu when searching for Drive items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenInSearch")]
        public virtual System.Nullable<bool> HiddenInSearch { get; set; }

        /// <summary>Order to display label in a list</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<long> Priority { get; set; }

        /// <summary>This Label should be shown in the apply menu.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shownInApply")]
        public virtual System.Nullable<bool> ShownInApply { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Label constraints governing the structure of a Label; such as, the maximum number of Fields allowed and maximum
    /// length of the label title.
    /// </summary>
    public class GoogleAppsDriveLabelsV2betaLabelLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The limits for Fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldLimits")]
        public virtual GoogleAppsDriveLabelsV2betaFieldLimits FieldLimits { get; set; }

        /// <summary>The maximum number of published Fields that can be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDeletedFields")]
        public virtual System.Nullable<int> MaxDeletedFields { get; set; }

        /// <summary>The maximum number of characters allowed for the description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDescriptionLength")]
        public virtual System.Nullable<int> MaxDescriptionLength { get; set; }

        /// <summary>The maximum number of draft revisions that will be kept before deleting old drafts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDraftRevisions")]
        public virtual System.Nullable<int> MaxDraftRevisions { get; set; }

        /// <summary>The maximum number of Fields allowed within the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxFields")]
        public virtual System.Nullable<int> MaxFields { get; set; }

        /// <summary>The maximum number of characters allowed for the title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTitleLength")]
        public virtual System.Nullable<int> MaxTitleLength { get; set; }

        /// <summary>Resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Lock that can be applied to a Label, Field, or Choice.</summary>
    public class GoogleAppsDriveLabelsV2betaLabelLock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The user's capabilities on this LabelLock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capabilities")]
        public virtual GoogleAppsDriveLabelsV2betaLabelLockCapabilities Capabilities { get; set; }

        /// <summary>
        /// The ID of the Selection Field Choice that should be locked. If present, `field_id` must also be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("choiceId")]
        public virtual string ChoiceId { get; set; }

        /// <summary>Output only. The time this LabelLock was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The user whose credentials were used to create the LabelLock. This will not be present if no
        /// user was responsible for creating the LabelLock.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual GoogleAppsDriveLabelsV2betaUserInfo Creator { get; set; }

        /// <summary>
        /// Output only. A timestamp indicating when this LabelLock was scheduled for deletion. This will be present
        /// only if this LabelLock is in the DELETING state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>The ID of the Field that should be locked. Empty if the whole Label should be locked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; }

        /// <summary>Output only. Resource name of this LabelLock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. A URI referring to the policy that created this Lock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyUri")]
        public virtual string PolicyUri { get; set; }

        /// <summary>Output only. This LabelLock's state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of a user's capabilities on a LabelLock.</summary>
    public class GoogleAppsDriveLabelsV2betaLabelLockCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the user is authorized to view the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canViewPolicy")]
        public virtual System.Nullable<bool> CanViewPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The permission that applies to a principal (user, group, audience) on a label.</summary>
    public class GoogleAppsDriveLabelsV2betaLabelPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Audience to grant a role to. The magic value of `audiences/default` may be used to apply the role to the
        /// default audience in the context of the organization that owns the Label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>
        /// Specifies the email address for a user or group pricinpal. Not populated for audience principals. User and
        /// Group permissions may only be inserted using email address. On update requests, if email address is
        /// specified, no principal should be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Group resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>Resource name of this permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Person resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual string Person { get; set; }

        /// <summary>The role the principal should have.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic properties of the Label.</summary>
    public class GoogleAppsDriveLabelsV2betaLabelProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of this Label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Title of the Label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities related to this Label when editing the Label.</summary>
    public class GoogleAppsDriveLabelsV2betaLabelSchemaCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the user can delete this Label. The user must have permission and the Label must be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDelete")]
        public virtual System.Nullable<bool> CanDelete { get; set; }

        /// <summary>
        /// Whether the user can disable this Label. The user must have permission and this Label must not already be
        /// disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDisable")]
        public virtual System.Nullable<bool> CanDisable { get; set; }

        /// <summary>
        /// Whether the user can enable this Label. The user must have permission and this Label must be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canEnable")]
        public virtual System.Nullable<bool> CanEnable { get; set; }

        /// <summary>Whether the user can change this Label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canUpdate")]
        public virtual System.Nullable<bool> CanUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The lifecycle state of an object, e.g. Label, Field, or Choice. The Lifecycle enforces the following
    /// transitions: * `UNPUBLISHED_DRAFT` (starting state) * `UNPUBLISHED_DRAFT` -&amp;gt; `PUBLISHED` *
    /// `UNPUBLISHED_DRAFT` -&amp;gt; (Deleted) * `PUBLISHED` -&amp;gt; `DISABLED` * `DISABLED` -&amp;gt; `PUBLISHED` *
    /// `DISABLED` -&amp;gt; (Deleted) The published and disabled states have some distinct characteristics: * Published
    /// - Some kinds of changes may be made to an object in this state, in which case `has_unpublished_changes` will be
    /// true. Some kinds of changes are not permitted. Generally, any change that would invalidate or cause new
    /// restrictions on existing metadata related to the Label will be rejected. * Disabled - When disabled, the
    /// configured `DisabledPolicy` will take effect.
    /// </summary>
    public class GoogleAppsDriveLabelsV2betaLifecycle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The policy that governs how to show a disabled label, field, or selection choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabledPolicy")]
        public virtual GoogleAppsDriveLabelsV2betaLifecycleDisabledPolicy DisabledPolicy { get; set; }

        /// <summary>Output only. Whether the object associated with this lifecycle has unpublished changes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUnpublishedChanges")]
        public virtual System.Nullable<bool> HasUnpublishedChanges { get; set; }

        /// <summary>Output only. The state of the object associated with this lifecycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The policy that governs how to treat a disabled label, field, or selection choice in different contexts.
    /// </summary>
    public class GoogleAppsDriveLabelsV2betaLifecycleDisabledPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to hide this disabled object in the search menu for Drive items. * When `false` the object will
        /// generally be shown in the UI as disabled (but still permit searching) when searching for Drive items. * When
        /// `true` the object will generally be hidden in the UI when searching for Drive items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hideInSearch")]
        public virtual System.Nullable<bool> HideInSearch { get; set; }

        /// <summary>
        /// Whether to show this disabled object in the apply menu on Drive items. * When `true` the object will
        /// generally be shown in the UI as disabled and is unselectable. * When `false` the object will generally be
        /// hidden in the UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showInApply")]
        public virtual System.Nullable<bool> ShowInApply { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a ListLabelLocksRequest.</summary>
    public class GoogleAppsDriveLabelsV2betaListLabelLocksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>LabelLocks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelLocks")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2betaLabelLock> LabelLocks { get; set; }

        /// <summary>The token of the next page in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing the permissions on a Label.</summary>
    public class GoogleAppsDriveLabelsV2betaListLabelPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelPermissions")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2betaLabelPermission> LabelPermissions { get; set; }

        /// <summary>The token of the next page in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing Labels.</summary>
    public class GoogleAppsDriveLabelsV2betaListLabelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2betaLabel> Labels { get; set; }

        /// <summary>The token of the next page in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Limits for list-variant of a Field type.</summary>
    public class GoogleAppsDriveLabelsV2betaListLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum number of values allowed for the Field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxEntries")]
        public virtual System.Nullable<int> MaxEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about whether a label component should be considered locked.</summary>
    public class GoogleAppsDriveLabelsV2betaLockStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Indicates whether this label component is the (direct) target of a LabelLock. A label component
        /// may be implicitly locked even if it is not the direct target of a LabelLock, in which case this field will
        /// be false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locked")]
        public virtual System.Nullable<bool> Locked { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Limits for long text Field type.</summary>
    public class GoogleAppsDriveLabelsV2betaLongTextLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum length allowed for a long text Field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLength")]
        public virtual System.Nullable<int> MaxLength { get; set; }

        /// <summary>Minimum length allowed for a long text Field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minLength")]
        public virtual System.Nullable<int> MinLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to publish a label.</summary>
    public class GoogleAppsDriveLabelsV2betaPublishLabelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The BCP-47 language code to use for evaluating localized field labels. When not specified, values in the
        /// default configured language will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an admin for
        /// the Label before allowing access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAdminAccess")]
        public virtual System.Nullable<bool> UseAdminAccess { get; set; }

        /// <summary>
        /// Provides control over how write requests are executed. Defaults to unset, which means last write wins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeControl")]
        public virtual GoogleAppsDriveLabelsV2betaWriteControl WriteControl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Limits for selection Field type.</summary>
    public class GoogleAppsDriveLabelsV2betaSelectionLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Limits for list-variant of a Field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listLimits")]
        public virtual GoogleAppsDriveLabelsV2betaListLimits ListLimits { get; set; }

        /// <summary>The max number of choices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxChoices")]
        public virtual System.Nullable<int> MaxChoices { get; set; }

        /// <summary>Maximum number of deleted choices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDeletedChoices")]
        public virtual System.Nullable<int> MaxDeletedChoices { get; set; }

        /// <summary>Maximum length for display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDisplayNameLength")]
        public virtual System.Nullable<int> MaxDisplayNameLength { get; set; }

        /// <summary>Maximum ID length for a selection options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIdLength")]
        public virtual System.Nullable<int> MaxIdLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Limits for text Field type.</summary>
    public class GoogleAppsDriveLabelsV2betaTextLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum length allowed for a text Field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLength")]
        public virtual System.Nullable<int> MaxLength { get; set; }

        /// <summary>Minimum length allowed for a text Field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minLength")]
        public virtual System.Nullable<int> MinLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to update the `CopyMode` of the given Label. Changes to this policy are not revisioned, do not require
    /// publishing, and take effect immediately. \
    /// </summary>
    public class GoogleAppsDriveLabelsV2betaUpdateLabelCopyModeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Indicates how the applied Label, and Field values should be copied when a Drive item is copied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyMode")]
        public virtual string CopyMode { get; set; }

        /// <summary>
        /// The BCP-47 language code to use for evaluating localized field labels. When not specified, values in the
        /// default configured language will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an admin for
        /// the Label before allowing access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAdminAccess")]
        public virtual System.Nullable<bool> UseAdminAccess { get; set; }

        /// <summary>When specified, only certain fields belonging to the indicated view will be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("view")]
        public virtual string View { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Updates a Label Permission. Permissions affect the Label resource as a whole, are not revisioned, and do not
    /// require publishing.
    /// </summary>
    public class GoogleAppsDriveLabelsV2betaUpdateLabelPermissionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The permission to create or update on the Label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelPermission")]
        public virtual GoogleAppsDriveLabelsV2betaLabelPermission LabelPermission { get; set; }

        /// <summary>Required. The parent Label resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Set to `true` in order to use the user's admin credentials. The server will verify the user is an admin for
        /// the Label before allowing access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAdminAccess")]
        public virtual System.Nullable<bool> UseAdminAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities of a user.</summary>
    public class GoogleAppsDriveLabelsV2betaUserCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Whether the user is allowed access to the label manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canAccessLabelManager")]
        public virtual System.Nullable<bool> CanAccessLabelManager { get; set; }

        /// <summary>Output only. Whether the user is an administrator for the shared labels feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canAdministrateLabels")]
        public virtual System.Nullable<bool> CanAdministrateLabels { get; set; }

        /// <summary>Output only. Whether the user is allowed to create new admin labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canCreateAdminLabels")]
        public virtual System.Nullable<bool> CanCreateAdminLabels { get; set; }

        /// <summary>Output only. Whether the user is allowed to create new shared labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canCreateSharedLabels")]
        public virtual System.Nullable<bool> CanCreateSharedLabels { get; set; }

        /// <summary>Output only. Resource name for the user capabilities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a user.</summary>
    public class GoogleAppsDriveLabelsV2betaUserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The identifier for this user who can be used with the People API to get more information. e.g.
        /// people/12345678
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual string Person { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Limits for Field.Type.USER.</summary>
    public class GoogleAppsDriveLabelsV2betaUserLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Limits for list-variant of a Field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listLimits")]
        public virtual GoogleAppsDriveLabelsV2betaListLimits ListLimits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides control over how write requests are executed. When not specified, the last write wins.
    /// </summary>
    public class GoogleAppsDriveLabelsV2betaWriteControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The revision_id of the label that the write request will be applied to. If this is not the latest revision
        /// of the label, the request will not be processed and will return a 400 Bad Request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredRevisionId")]
        public virtual string RequiredRevisionId { get; set; }

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
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to/from
    /// color representations in various languages over compactness. For example, the fields of this representation can
    /// be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't carry information about the
    /// absolute color space that should be used to interpret the RGB value (e.g. sRGB, Adobe RGB, DCI-P3, BT.2020,
    /// etc.). By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most 1e-5. Example (Java): import com.google.type.Color; // ... public static
    /// java.awt.Color fromProto(Color protocolor) { float alpha = protocolor.hasAlpha() ?
    /// protocolor.getAlpha().getValue() : 1.0; return new java.awt.Color( protocolor.getRed(), protocolor.getGreen(),
    /// protocolor.getBlue(), alpha); } public static Color toProto(java.awt.Color color) { float red = (float)
    /// color.getRed(); float green = (float) color.getGreen(); float blue = (float) color.getBlue(); float denominator
    /// = 255.0; Color.Builder resultBuilder = Color .newBuilder() .setRed(red / denominator) .setGreen(green /
    /// denominator) .setBlue(blue / denominator); int alpha = color.getAlpha(); if (alpha != 255) { result.setAlpha(
    /// FloatValue .newBuilder() .setValue(((float) alpha) / denominator) .build()); } return resultBuilder.build(); }
    /// // ... Example (iOS / Obj-C): // ... static UIColor* fromProto(Color* protocolor) { float red = [protocolor
    /// red]; float green = [protocolor green]; float blue = [protocolor blue]; FloatValue* alpha_wrapper = [protocolor
    /// alpha]; float alpha = 1.0; if (alpha_wrapper != nil) { alpha = [alpha_wrapper value]; } return [UIColor
    /// colorWithRed:red green:green blue:blue alpha:alpha]; } static Color* toProto(UIColor* color) { CGFloat red,
    /// green, blue, alpha; if (![color getRed:&amp;amp;red green:&amp;amp;green blue:&amp;amp;blue
    /// alpha:&amp;amp;alpha]) { return nil; } Color* result = [[Color alloc] init]; [result setRed:red]; [result
    /// setGreen:green]; [result setBlue:blue]; if (alpha &amp;lt;= 0.9999) { [result
    /// setAlpha:floatWrapperWithValue(alpha)]; } [result autorelease]; return result; } // ... Example (JavaScript): //
    /// ... var protoToCssColor = function(rgb_color) { var redFrac = rgb_color.red || 0.0; var greenFrac =
    /// rgb_color.green || 0.0; var blueFrac = rgb_color.blue || 0.0; var red = Math.floor(redFrac * 255); var green =
    /// Math.floor(greenFrac * 255); var blue = Math.floor(blueFrac * 255); if (!('alpha' in rgb_color)) { return
    /// rgbToCssColor(red, green, blue); } var alphaFrac = rgb_color.alpha.value || 0.0; var rgbParams = [red, green,
    /// blue].join(','); return ['rgba(', rgbParams, ',', alphaFrac, ')'].join(''); }; var rgbToCssColor = function(red,
    /// green, blue) { var rgbNumber = new Number((red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue); var
    /// hexString = rgbNumber.toString(16); var missingZeros = 6 - hexString.length; var resultBuilder = ['#']; for (var
    /// i = 0; i &amp;lt; missingZeros; i++) { resultBuilder.push('0'); } resultBuilder.push(hexString); return
    /// resultBuilder.join(''); }; // ...
    /// </summary>
    public class GoogleTypeColor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is, the final pixel color is defined by
        /// the equation: `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)` This means that a
        /// value of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent
        /// color. This uses a wrapper message rather than a simple float scalar so that it is possible to distinguish
        /// between a default value and the value being unset. If omitted, this color object is rendered as a solid
        /// color (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

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
    public class GoogleTypeDate : Google.Apis.Requests.IDirectResponseSchema
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
}
