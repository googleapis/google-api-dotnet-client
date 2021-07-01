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

namespace Google.Apis.AccessApproval.v1
{
    /// <summary>The AccessApproval Service.</summary>
    public class AccessApprovalService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AccessApprovalService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AccessApprovalService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "accessapproval";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://accessapproval.googleapis.com/";
        #else
            "https://accessapproval.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://accessapproval.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Access Approval API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Access Approval API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for AccessApproval requests.</summary>
    public abstract class AccessApprovalBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AccessApprovalBaseServiceRequest instance.</summary>
        protected AccessApprovalBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AccessApproval parameter list.</summary>
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            ApprovalRequests = new ApprovalRequestsResource(service);
        }

        /// <summary>Gets the ApprovalRequests resource.</summary>
        public virtual ApprovalRequestsResource ApprovalRequests { get; }

        /// <summary>The "approvalRequests" collection of methods.</summary>
        public class ApprovalRequestsResource
        {
            private const string Resource = "approvalRequests";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ApprovalRequestsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Approves a request and returns the updated ApprovalRequest. Returns NOT_FOUND if the request does not
            /// exist. Returns FAILED_PRECONDITION if the request exists but is not in a pending state.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Name of the approval request to approve.</param>
            public virtual ApproveRequest Approve(Google.Apis.AccessApproval.v1.Data.ApproveApprovalRequestMessage body, string name)
            {
                return new ApproveRequest(service, body, name);
            }

            /// <summary>
            /// Approves a request and returns the updated ApprovalRequest. Returns NOT_FOUND if the request does not
            /// exist. Returns FAILED_PRECONDITION if the request exists but is not in a pending state.
            /// </summary>
            public class ApproveRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ApprovalRequest>
            {
                /// <summary>Constructs a new Approve request.</summary>
                public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessApproval.v1.Data.ApproveApprovalRequestMessage body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Name of the approval request to approve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessApproval.v1.Data.ApproveApprovalRequestMessage Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "approve";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:approve";

                /// <summary>Initializes Approve parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/approvalRequests/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Dismisses a request. Returns the updated ApprovalRequest. NOTE: This does not deny access to the
            /// resource if another request has been made and approved. It is equivalent in effect to ignoring the
            /// request altogether. Returns NOT_FOUND if the request does not exist. Returns FAILED_PRECONDITION if the
            /// request exists but is not in a pending state.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Name of the ApprovalRequest to dismiss.</param>
            public virtual DismissRequest Dismiss(Google.Apis.AccessApproval.v1.Data.DismissApprovalRequestMessage body, string name)
            {
                return new DismissRequest(service, body, name);
            }

            /// <summary>
            /// Dismisses a request. Returns the updated ApprovalRequest. NOTE: This does not deny access to the
            /// resource if another request has been made and approved. It is equivalent in effect to ignoring the
            /// request altogether. Returns NOT_FOUND if the request does not exist. Returns FAILED_PRECONDITION if the
            /// request exists but is not in a pending state.
            /// </summary>
            public class DismissRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ApprovalRequest>
            {
                /// <summary>Constructs a new Dismiss request.</summary>
                public DismissRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessApproval.v1.Data.DismissApprovalRequestMessage body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Name of the ApprovalRequest to dismiss.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessApproval.v1.Data.DismissApprovalRequestMessage Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "dismiss";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:dismiss";

                /// <summary>Initializes Dismiss parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/approvalRequests/[^/]+$",
                    });
                }
            }

            /// <summary>Gets an approval request. Returns NOT_FOUND if the request does not exist.</summary>
            /// <param name="name">Name of the approval request to retrieve.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets an approval request. Returns NOT_FOUND if the request does not exist.</summary>
            public class GetRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ApprovalRequest>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Name of the approval request to retrieve.</summary>
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
                        Pattern = @"^folders/[^/]+/approvalRequests/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists approval requests associated with a project, folder, or organization. Approval requests can be
            /// filtered by state (pending, active, dismissed). The order is reverse chronological.
            /// </summary>
            /// <param name="parent">
            /// The parent resource. This may be "projects/{project}", "folders/{folder}", or
            /// "organizations/{organization}".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists approval requests associated with a project, folder, or organization. Approval requests can be
            /// filtered by state (pending, active, dismissed). The order is reverse chronological.
            /// </summary>
            public class ListRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ListApprovalRequestsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The parent resource. This may be "projects/{project}", "folders/{folder}", or
                /// "organizations/{organization}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// A filter on the type of approval requests to retrieve. Must be one of the following values: * [not
                /// set]: Requests that are pending or have active approvals. * ALL: All requests. * PENDING: Only
                /// pending requests. * ACTIVE: Only active (i.e. currently approved) requests. * DISMISSED: Only
                /// requests that have been dismissed, or requests that are not approved and past expiration. * EXPIRED:
                /// Only requests that have been approved, and the approval has expired. * HISTORY: Active, dismissed
                /// and expired requests.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Requested page size.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying the page of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/approvalRequests";

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
                        Pattern = @"^folders/[^/]+$",
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
        /// Deletes the settings associated with a project, folder, or organization. This will have the effect of
        /// disabling Access Approval for the project, folder, or organization, but only if all ancestors also have
        /// Access Approval disabled. If Access Approval is enabled at a higher level of the hierarchy, then Access
        /// Approval will still be enabled at this level as the settings are inherited.
        /// </summary>
        /// <param name="name">Name of the AccessApprovalSettings to delete.</param>
        public virtual DeleteAccessApprovalSettingsRequest DeleteAccessApprovalSettings(string name)
        {
            return new DeleteAccessApprovalSettingsRequest(service, name);
        }

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization. This will have the effect of
        /// disabling Access Approval for the project, folder, or organization, but only if all ancestors also have
        /// Access Approval disabled. If Access Approval is enabled at a higher level of the hierarchy, then Access
        /// Approval will still be enabled at this level as the settings are inherited.
        /// </summary>
        public class DeleteAccessApprovalSettingsRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.Empty>
        {
            /// <summary>Constructs a new DeleteAccessApprovalSettings request.</summary>
            public DeleteAccessApprovalSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Name of the AccessApprovalSettings to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deleteAccessApprovalSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes DeleteAccessApprovalSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/accessApprovalSettings$",
                });
            }
        }

        /// <summary>Gets the settings associated with a project, folder, or organization.</summary>
        /// <param name="name">Name of the AccessApprovalSettings to retrieve.</param>
        public virtual GetAccessApprovalSettingsRequest GetAccessApprovalSettings(string name)
        {
            return new GetAccessApprovalSettingsRequest(service, name);
        }

        /// <summary>Gets the settings associated with a project, folder, or organization.</summary>
        public class GetAccessApprovalSettingsRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings>
        {
            /// <summary>Constructs a new GetAccessApprovalSettings request.</summary>
            public GetAccessApprovalSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Name of the AccessApprovalSettings to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAccessApprovalSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetAccessApprovalSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/accessApprovalSettings$",
                });
            }
        }

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization. Settings to update are determined
        /// by the value of field_mask.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the settings. Format is one of: * "projects/{project}/accessApprovalSettings" *
        /// "folders/{folder}/accessApprovalSettings" * "organizations/{organization}/accessApprovalSettings"
        /// </param>
        public virtual UpdateAccessApprovalSettingsRequest UpdateAccessApprovalSettings(Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings body, string name)
        {
            return new UpdateAccessApprovalSettingsRequest(service, body, name);
        }

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization. Settings to update are determined
        /// by the value of field_mask.
        /// </summary>
        public class UpdateAccessApprovalSettingsRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings>
        {
            /// <summary>Constructs a new UpdateAccessApprovalSettings request.</summary>
            public UpdateAccessApprovalSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the settings. Format is one of: * "projects/{project}/accessApprovalSettings" *
            /// "folders/{folder}/accessApprovalSettings" * "organizations/{organization}/accessApprovalSettings"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The update mask applies to the settings. Only the top level fields of AccessApprovalSettings
            /// (notification_emails &amp;amp; enrolled_services) are supported. For each field, if it is included, the
            /// currently stored value will be entirely overwritten with the value of the field passed in this request.
            /// For the `FieldMask` definition, see
            /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask If this field is
            /// left unset, only the notification_emails field will be updated.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateAccessApprovalSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateAccessApprovalSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/accessApprovalSettings$",
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

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            ApprovalRequests = new ApprovalRequestsResource(service);
        }

        /// <summary>Gets the ApprovalRequests resource.</summary>
        public virtual ApprovalRequestsResource ApprovalRequests { get; }

        /// <summary>The "approvalRequests" collection of methods.</summary>
        public class ApprovalRequestsResource
        {
            private const string Resource = "approvalRequests";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ApprovalRequestsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Approves a request and returns the updated ApprovalRequest. Returns NOT_FOUND if the request does not
            /// exist. Returns FAILED_PRECONDITION if the request exists but is not in a pending state.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Name of the approval request to approve.</param>
            public virtual ApproveRequest Approve(Google.Apis.AccessApproval.v1.Data.ApproveApprovalRequestMessage body, string name)
            {
                return new ApproveRequest(service, body, name);
            }

            /// <summary>
            /// Approves a request and returns the updated ApprovalRequest. Returns NOT_FOUND if the request does not
            /// exist. Returns FAILED_PRECONDITION if the request exists but is not in a pending state.
            /// </summary>
            public class ApproveRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ApprovalRequest>
            {
                /// <summary>Constructs a new Approve request.</summary>
                public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessApproval.v1.Data.ApproveApprovalRequestMessage body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Name of the approval request to approve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessApproval.v1.Data.ApproveApprovalRequestMessage Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "approve";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:approve";

                /// <summary>Initializes Approve parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/approvalRequests/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Dismisses a request. Returns the updated ApprovalRequest. NOTE: This does not deny access to the
            /// resource if another request has been made and approved. It is equivalent in effect to ignoring the
            /// request altogether. Returns NOT_FOUND if the request does not exist. Returns FAILED_PRECONDITION if the
            /// request exists but is not in a pending state.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Name of the ApprovalRequest to dismiss.</param>
            public virtual DismissRequest Dismiss(Google.Apis.AccessApproval.v1.Data.DismissApprovalRequestMessage body, string name)
            {
                return new DismissRequest(service, body, name);
            }

            /// <summary>
            /// Dismisses a request. Returns the updated ApprovalRequest. NOTE: This does not deny access to the
            /// resource if another request has been made and approved. It is equivalent in effect to ignoring the
            /// request altogether. Returns NOT_FOUND if the request does not exist. Returns FAILED_PRECONDITION if the
            /// request exists but is not in a pending state.
            /// </summary>
            public class DismissRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ApprovalRequest>
            {
                /// <summary>Constructs a new Dismiss request.</summary>
                public DismissRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessApproval.v1.Data.DismissApprovalRequestMessage body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Name of the ApprovalRequest to dismiss.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessApproval.v1.Data.DismissApprovalRequestMessage Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "dismiss";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:dismiss";

                /// <summary>Initializes Dismiss parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/approvalRequests/[^/]+$",
                    });
                }
            }

            /// <summary>Gets an approval request. Returns NOT_FOUND if the request does not exist.</summary>
            /// <param name="name">Name of the approval request to retrieve.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets an approval request. Returns NOT_FOUND if the request does not exist.</summary>
            public class GetRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ApprovalRequest>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Name of the approval request to retrieve.</summary>
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
                        Pattern = @"^organizations/[^/]+/approvalRequests/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists approval requests associated with a project, folder, or organization. Approval requests can be
            /// filtered by state (pending, active, dismissed). The order is reverse chronological.
            /// </summary>
            /// <param name="parent">
            /// The parent resource. This may be "projects/{project}", "folders/{folder}", or
            /// "organizations/{organization}".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists approval requests associated with a project, folder, or organization. Approval requests can be
            /// filtered by state (pending, active, dismissed). The order is reverse chronological.
            /// </summary>
            public class ListRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ListApprovalRequestsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The parent resource. This may be "projects/{project}", "folders/{folder}", or
                /// "organizations/{organization}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// A filter on the type of approval requests to retrieve. Must be one of the following values: * [not
                /// set]: Requests that are pending or have active approvals. * ALL: All requests. * PENDING: Only
                /// pending requests. * ACTIVE: Only active (i.e. currently approved) requests. * DISMISSED: Only
                /// requests that have been dismissed, or requests that are not approved and past expiration. * EXPIRED:
                /// Only requests that have been approved, and the approval has expired. * HISTORY: Active, dismissed
                /// and expired requests.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Requested page size.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying the page of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/approvalRequests";

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
                        Pattern = @"^organizations/[^/]+$",
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
        /// Deletes the settings associated with a project, folder, or organization. This will have the effect of
        /// disabling Access Approval for the project, folder, or organization, but only if all ancestors also have
        /// Access Approval disabled. If Access Approval is enabled at a higher level of the hierarchy, then Access
        /// Approval will still be enabled at this level as the settings are inherited.
        /// </summary>
        /// <param name="name">Name of the AccessApprovalSettings to delete.</param>
        public virtual DeleteAccessApprovalSettingsRequest DeleteAccessApprovalSettings(string name)
        {
            return new DeleteAccessApprovalSettingsRequest(service, name);
        }

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization. This will have the effect of
        /// disabling Access Approval for the project, folder, or organization, but only if all ancestors also have
        /// Access Approval disabled. If Access Approval is enabled at a higher level of the hierarchy, then Access
        /// Approval will still be enabled at this level as the settings are inherited.
        /// </summary>
        public class DeleteAccessApprovalSettingsRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.Empty>
        {
            /// <summary>Constructs a new DeleteAccessApprovalSettings request.</summary>
            public DeleteAccessApprovalSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Name of the AccessApprovalSettings to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deleteAccessApprovalSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes DeleteAccessApprovalSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/accessApprovalSettings$",
                });
            }
        }

        /// <summary>Gets the settings associated with a project, folder, or organization.</summary>
        /// <param name="name">Name of the AccessApprovalSettings to retrieve.</param>
        public virtual GetAccessApprovalSettingsRequest GetAccessApprovalSettings(string name)
        {
            return new GetAccessApprovalSettingsRequest(service, name);
        }

        /// <summary>Gets the settings associated with a project, folder, or organization.</summary>
        public class GetAccessApprovalSettingsRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings>
        {
            /// <summary>Constructs a new GetAccessApprovalSettings request.</summary>
            public GetAccessApprovalSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Name of the AccessApprovalSettings to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAccessApprovalSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetAccessApprovalSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/accessApprovalSettings$",
                });
            }
        }

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization. Settings to update are determined
        /// by the value of field_mask.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the settings. Format is one of: * "projects/{project}/accessApprovalSettings" *
        /// "folders/{folder}/accessApprovalSettings" * "organizations/{organization}/accessApprovalSettings"
        /// </param>
        public virtual UpdateAccessApprovalSettingsRequest UpdateAccessApprovalSettings(Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings body, string name)
        {
            return new UpdateAccessApprovalSettingsRequest(service, body, name);
        }

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization. Settings to update are determined
        /// by the value of field_mask.
        /// </summary>
        public class UpdateAccessApprovalSettingsRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings>
        {
            /// <summary>Constructs a new UpdateAccessApprovalSettings request.</summary>
            public UpdateAccessApprovalSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the settings. Format is one of: * "projects/{project}/accessApprovalSettings" *
            /// "folders/{folder}/accessApprovalSettings" * "organizations/{organization}/accessApprovalSettings"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The update mask applies to the settings. Only the top level fields of AccessApprovalSettings
            /// (notification_emails &amp;amp; enrolled_services) are supported. For each field, if it is included, the
            /// currently stored value will be entirely overwritten with the value of the field passed in this request.
            /// For the `FieldMask` definition, see
            /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask If this field is
            /// left unset, only the notification_emails field will be updated.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateAccessApprovalSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateAccessApprovalSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/accessApprovalSettings$",
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
            ApprovalRequests = new ApprovalRequestsResource(service);
        }

        /// <summary>Gets the ApprovalRequests resource.</summary>
        public virtual ApprovalRequestsResource ApprovalRequests { get; }

        /// <summary>The "approvalRequests" collection of methods.</summary>
        public class ApprovalRequestsResource
        {
            private const string Resource = "approvalRequests";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ApprovalRequestsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Approves a request and returns the updated ApprovalRequest. Returns NOT_FOUND if the request does not
            /// exist. Returns FAILED_PRECONDITION if the request exists but is not in a pending state.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Name of the approval request to approve.</param>
            public virtual ApproveRequest Approve(Google.Apis.AccessApproval.v1.Data.ApproveApprovalRequestMessage body, string name)
            {
                return new ApproveRequest(service, body, name);
            }

            /// <summary>
            /// Approves a request and returns the updated ApprovalRequest. Returns NOT_FOUND if the request does not
            /// exist. Returns FAILED_PRECONDITION if the request exists but is not in a pending state.
            /// </summary>
            public class ApproveRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ApprovalRequest>
            {
                /// <summary>Constructs a new Approve request.</summary>
                public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessApproval.v1.Data.ApproveApprovalRequestMessage body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Name of the approval request to approve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessApproval.v1.Data.ApproveApprovalRequestMessage Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "approve";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:approve";

                /// <summary>Initializes Approve parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/approvalRequests/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Dismisses a request. Returns the updated ApprovalRequest. NOTE: This does not deny access to the
            /// resource if another request has been made and approved. It is equivalent in effect to ignoring the
            /// request altogether. Returns NOT_FOUND if the request does not exist. Returns FAILED_PRECONDITION if the
            /// request exists but is not in a pending state.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Name of the ApprovalRequest to dismiss.</param>
            public virtual DismissRequest Dismiss(Google.Apis.AccessApproval.v1.Data.DismissApprovalRequestMessage body, string name)
            {
                return new DismissRequest(service, body, name);
            }

            /// <summary>
            /// Dismisses a request. Returns the updated ApprovalRequest. NOTE: This does not deny access to the
            /// resource if another request has been made and approved. It is equivalent in effect to ignoring the
            /// request altogether. Returns NOT_FOUND if the request does not exist. Returns FAILED_PRECONDITION if the
            /// request exists but is not in a pending state.
            /// </summary>
            public class DismissRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ApprovalRequest>
            {
                /// <summary>Constructs a new Dismiss request.</summary>
                public DismissRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessApproval.v1.Data.DismissApprovalRequestMessage body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Name of the ApprovalRequest to dismiss.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessApproval.v1.Data.DismissApprovalRequestMessage Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "dismiss";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:dismiss";

                /// <summary>Initializes Dismiss parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/approvalRequests/[^/]+$",
                    });
                }
            }

            /// <summary>Gets an approval request. Returns NOT_FOUND if the request does not exist.</summary>
            /// <param name="name">Name of the approval request to retrieve.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets an approval request. Returns NOT_FOUND if the request does not exist.</summary>
            public class GetRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ApprovalRequest>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Name of the approval request to retrieve.</summary>
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
                        Pattern = @"^projects/[^/]+/approvalRequests/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists approval requests associated with a project, folder, or organization. Approval requests can be
            /// filtered by state (pending, active, dismissed). The order is reverse chronological.
            /// </summary>
            /// <param name="parent">
            /// The parent resource. This may be "projects/{project}", "folders/{folder}", or
            /// "organizations/{organization}".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists approval requests associated with a project, folder, or organization. Approval requests can be
            /// filtered by state (pending, active, dismissed). The order is reverse chronological.
            /// </summary>
            public class ListRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.ListApprovalRequestsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The parent resource. This may be "projects/{project}", "folders/{folder}", or
                /// "organizations/{organization}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// A filter on the type of approval requests to retrieve. Must be one of the following values: * [not
                /// set]: Requests that are pending or have active approvals. * ALL: All requests. * PENDING: Only
                /// pending requests. * ACTIVE: Only active (i.e. currently approved) requests. * DISMISSED: Only
                /// requests that have been dismissed, or requests that are not approved and past expiration. * EXPIRED:
                /// Only requests that have been approved, and the approval has expired. * HISTORY: Active, dismissed
                /// and expired requests.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Requested page size.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying the page of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/approvalRequests";

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

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization. This will have the effect of
        /// disabling Access Approval for the project, folder, or organization, but only if all ancestors also have
        /// Access Approval disabled. If Access Approval is enabled at a higher level of the hierarchy, then Access
        /// Approval will still be enabled at this level as the settings are inherited.
        /// </summary>
        /// <param name="name">Name of the AccessApprovalSettings to delete.</param>
        public virtual DeleteAccessApprovalSettingsRequest DeleteAccessApprovalSettings(string name)
        {
            return new DeleteAccessApprovalSettingsRequest(service, name);
        }

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization. This will have the effect of
        /// disabling Access Approval for the project, folder, or organization, but only if all ancestors also have
        /// Access Approval disabled. If Access Approval is enabled at a higher level of the hierarchy, then Access
        /// Approval will still be enabled at this level as the settings are inherited.
        /// </summary>
        public class DeleteAccessApprovalSettingsRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.Empty>
        {
            /// <summary>Constructs a new DeleteAccessApprovalSettings request.</summary>
            public DeleteAccessApprovalSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Name of the AccessApprovalSettings to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deleteAccessApprovalSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes DeleteAccessApprovalSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/accessApprovalSettings$",
                });
            }
        }

        /// <summary>Gets the settings associated with a project, folder, or organization.</summary>
        /// <param name="name">Name of the AccessApprovalSettings to retrieve.</param>
        public virtual GetAccessApprovalSettingsRequest GetAccessApprovalSettings(string name)
        {
            return new GetAccessApprovalSettingsRequest(service, name);
        }

        /// <summary>Gets the settings associated with a project, folder, or organization.</summary>
        public class GetAccessApprovalSettingsRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings>
        {
            /// <summary>Constructs a new GetAccessApprovalSettings request.</summary>
            public GetAccessApprovalSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Name of the AccessApprovalSettings to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAccessApprovalSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetAccessApprovalSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/accessApprovalSettings$",
                });
            }
        }

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization. Settings to update are determined
        /// by the value of field_mask.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the settings. Format is one of: * "projects/{project}/accessApprovalSettings" *
        /// "folders/{folder}/accessApprovalSettings" * "organizations/{organization}/accessApprovalSettings"
        /// </param>
        public virtual UpdateAccessApprovalSettingsRequest UpdateAccessApprovalSettings(Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings body, string name)
        {
            return new UpdateAccessApprovalSettingsRequest(service, body, name);
        }

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization. Settings to update are determined
        /// by the value of field_mask.
        /// </summary>
        public class UpdateAccessApprovalSettingsRequest : AccessApprovalBaseServiceRequest<Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings>
        {
            /// <summary>Constructs a new UpdateAccessApprovalSettings request.</summary>
            public UpdateAccessApprovalSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the settings. Format is one of: * "projects/{project}/accessApprovalSettings" *
            /// "folders/{folder}/accessApprovalSettings" * "organizations/{organization}/accessApprovalSettings"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The update mask applies to the settings. Only the top level fields of AccessApprovalSettings
            /// (notification_emails &amp;amp; enrolled_services) are supported. For each field, if it is included, the
            /// currently stored value will be entirely overwritten with the value of the field passed in this request.
            /// For the `FieldMask` definition, see
            /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask If this field is
            /// left unset, only the notification_emails field will be updated.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessApproval.v1.Data.AccessApprovalSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateAccessApprovalSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateAccessApprovalSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/accessApprovalSettings$",
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
namespace Google.Apis.AccessApproval.v1.Data
{
    /// <summary>Settings on a Project/Folder/Organization related to Access Approval.</summary>
    public class AccessApprovalSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. This field is read only (not settable via UpdateAccessAccessApprovalSettings method). If the
        /// field is true, that indicates that at least one service is enrolled for Access Approval in one or more
        /// ancestors of the Project or Folder (this field will always be unset for the organization since organizations
        /// do not have ancestors).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrolledAncestor")]
        public virtual System.Nullable<bool> EnrolledAncestor { get; set; }

        /// <summary>
        /// A list of Google Cloud Services for which the given resource has Access Approval enrolled. Access requests
        /// for the resource given by name against any of these services contained here will be required to have
        /// explicit approval. If name refers to an organization, enrollment can be done for individual services. If
        /// name refers to a folder or project, enrollment can only be done on an all or nothing basis. If a
        /// cloud_product is repeated in this list, the first entry will be honored and all following entries will be
        /// discarded. A maximum of 10 enrolled services will be enforced, to be expanded as the set of supported
        /// services is expanded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrolledServices")]
        public virtual System.Collections.Generic.IList<EnrolledService> EnrolledServices { get; set; }

        /// <summary>
        /// The resource name of the settings. Format is one of: * "projects/{project}/accessApprovalSettings" *
        /// "folders/{folder}/accessApprovalSettings" * "organizations/{organization}/accessApprovalSettings"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A list of email addresses to which notifications relating to approval requests should be sent. Notifications
        /// relating to a resource will be sent to all emails in the settings of ancestor resources of that resource. A
        /// maximum of 50 email addresses are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationEmails")]
        public virtual System.Collections.Generic.IList<string> NotificationEmails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Home office and physical location of the principal.</summary>
    public class AccessLocations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The "home office" location of the principal. A two-letter country code (ISO 3166-1 alpha-2), such as "US",
        /// "DE" or "GB" or a region code. In some limited situations Google systems may refer refer to a region code
        /// instead of a country code. Possible Region Codes: * ASI: Asia * EUR: Europe * OCE: Oceania * AFR: Africa *
        /// NAM: North America * SAM: South America * ANT: Antarctica * ANY: Any location
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalOfficeCountry")]
        public virtual string PrincipalOfficeCountry { get; set; }

        /// <summary>
        /// Physical location of the principal at the time of the access. A two-letter country code (ISO 3166-1
        /// alpha-2), such as "US", "DE" or "GB" or a region code. In some limited situations Google systems may refer
        /// refer to a region code instead of a country code. Possible Region Codes: * ASI: Asia * EUR: Europe * OCE:
        /// Oceania * AFR: Africa * NAM: North America * SAM: South America * ANT: Antarctica * ANY: Any location
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalPhysicalLocationCountry")]
        public virtual string PrincipalPhysicalLocationCountry { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AccessReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>More detail about certain reason types. See comments for each type above.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>Type of access justification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request for the customer to approve access to a resource.</summary>
    public class ApprovalRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access was approved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approve")]
        public virtual ApproveDecision Approve { get; set; }

        /// <summary>The request was dismissed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dismiss")]
        public virtual DismissDecision Dismiss { get; set; }

        /// <summary>
        /// The resource name of the request. Format is
        /// "{projects|folders|organizations}/{id}/approvalRequests/{approval_request}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The time at which approval was requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual object RequestTime { get; set; }

        /// <summary>
        /// The requested expiration for the approval. If the request is approved, access will be granted from the time
        /// of approval until the expiration time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedExpiration")]
        public virtual object RequestedExpiration { get; set; }

        /// <summary>The locations for which approval is being requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedLocations")]
        public virtual AccessLocations RequestedLocations { get; set; }

        /// <summary>The justification for which approval is being requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedReason")]
        public virtual AccessReason RequestedReason { get; set; }

        /// <summary>
        /// The resource for which approval is being requested. The format of the resource name is defined at
        /// https://cloud.google.com/apis/design/resource_names. The resource name here may either be a "full" resource
        /// name (e.g. "//library.googleapis.com/shelves/shelf1/books/book2") or a "relative" resource name (e.g.
        /// "shelves/shelf1/books/book2") as described in the resource name specification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedResourceName")]
        public virtual string RequestedResourceName { get; set; }

        /// <summary>Properties related to the resource represented by requested_resource_name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedResourceProperties")]
        public virtual ResourceProperties RequestedResourceProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to approve an ApprovalRequest.</summary>
    public class ApproveApprovalRequestMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The expiration time of this approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A decision that has been made to approve access to a resource.</summary>
    public class ApproveDecision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which approval was granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approveTime")]
        public virtual object ApproveTime { get; set; }

        /// <summary>The time at which the approval expires.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to dismiss an approval request.</summary>
    public class DismissApprovalRequestMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A decision that has been made to dismiss an approval request.</summary>
    public class DismissDecision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the approval request was dismissed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dismissTime")]
        public virtual object DismissTime { get; set; }

        /// <summary>
        /// This field will be true if the ApprovalRequest was implcitly dismissed due to inaction by the access
        /// approval approvers (the request is not acted on by the approvers before the exiration time).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("implicit")]
        public virtual System.Nullable<bool> Implicit__ { get; set; }

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

    /// <summary>Represents the enrollment of a cloud resource into a specific service.</summary>
    public class EnrolledService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The product for which Access Approval will be enrolled. Allowed values are listed below (case-sensitive): *
        /// all * GA * App Engine * BigQuery * Cloud Bigtable * Cloud Key Management Service * Compute Engine * Cloud
        /// Dataflow * Cloud DLP * Cloud EKM * Cloud HSM * Cloud Identity and Access Management * Cloud Logging * Cloud
        /// Pub/Sub * Cloud Spanner * Cloud SQL * Cloud Storage * Google Kubernetes Engine * Persistent Disk Note: These
        /// values are supported as input for legacy purposes, but will not be returned from the API. * all * ga-only *
        /// appengine.googleapis.com * bigquery.googleapis.com * bigtable.googleapis.com * container.googleapis.com *
        /// cloudkms.googleapis.com * cloudsql.googleapis.com * compute.googleapis.com * dataflow.googleapis.com *
        /// dlp.googleapis.com * iam.googleapis.com * logging.googleapis.com * pubsub.googleapis.com *
        /// spanner.googleapis.com * storage.googleapis.com Calls to UpdateAccessApprovalSettings using 'all' or any of
        /// the XXX.googleapis.com will be translated to the associated product name ('all', 'App Engine', etc.). Note:
        /// 'all' will enroll the resource in all products supported at both 'GA' and 'Preview' levels. More information
        /// about levels of support is available at https://cloud.google.com/access-approval/docs/supported-services
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProduct")]
        public virtual string CloudProduct { get; set; }

        /// <summary>The enrollment level of the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrollmentLevel")]
        public virtual string EnrollmentLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to listing of ApprovalRequest objects.</summary>
    public class ListApprovalRequestsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Approval request details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalRequests")]
        public virtual System.Collections.Generic.IList<ApprovalRequest> ApprovalRequests { get; set; }

        /// <summary>Token to retrieve the next page of results, or empty if there are no more.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties associated with the resource of the request.</summary>
    public class ResourceProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether an approval will exclude the descendants of the resource being requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludesDescendants")]
        public virtual System.Nullable<bool> ExcludesDescendants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
