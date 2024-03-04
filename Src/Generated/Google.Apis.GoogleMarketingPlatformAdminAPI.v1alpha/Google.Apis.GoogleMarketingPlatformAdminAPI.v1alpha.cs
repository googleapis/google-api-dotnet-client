// Copyright 2024 Google LLC
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

namespace Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha
{
    /// <summary>The GoogleMarketingPlatformAdminAPI Service.</summary>
    public class GoogleMarketingPlatformAdminAPIService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GoogleMarketingPlatformAdminAPIService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GoogleMarketingPlatformAdminAPIService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Organizations = new OrganizationsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://marketingplatformadmin.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://marketingplatformadmin.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "marketingplatformadmin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Marketing Platform Admin API.</summary>
        public class Scope
        {
            /// <summary>View your Google Analytics product account data in GMP home</summary>
            public static string MarketingplatformadminAnalyticsRead = "https://www.googleapis.com/auth/marketingplatformadmin.analytics.read";

            /// <summary>Manage your Google Analytics product account data in GMP home</summary>
            public static string MarketingplatformadminAnalyticsUpdate = "https://www.googleapis.com/auth/marketingplatformadmin.analytics.update";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Marketing Platform Admin API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View your Google Analytics product account data in GMP home</summary>
            public const string MarketingplatformadminAnalyticsRead = "https://www.googleapis.com/auth/marketingplatformadmin.analytics.read";

            /// <summary>Manage your Google Analytics product account data in GMP home</summary>
            public const string MarketingplatformadminAnalyticsUpdate = "https://www.googleapis.com/auth/marketingplatformadmin.analytics.update";
        }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }
    }

    /// <summary>A base abstract class for GoogleMarketingPlatformAdminAPI requests.</summary>
    public abstract class GoogleMarketingPlatformAdminAPIBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GoogleMarketingPlatformAdminAPIBaseServiceRequest instance.</summary>
        protected GoogleMarketingPlatformAdminAPIBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes GoogleMarketingPlatformAdminAPI parameter list.</summary>
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
            AnalyticsAccountLinks = new AnalyticsAccountLinksResource(service);
        }

        /// <summary>Gets the AnalyticsAccountLinks resource.</summary>
        public virtual AnalyticsAccountLinksResource AnalyticsAccountLinks { get; }

        /// <summary>The "analyticsAccountLinks" collection of methods.</summary>
        public class AnalyticsAccountLinksResource
        {
            private const string Resource = "analyticsAccountLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AnalyticsAccountLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates the link between the Analytics account and the Google Marketing Platform organization. User
            /// needs to be an org user, and admin on the Analytics account to create the link. If the account is
            /// already linked to an organization, user needs to unlink the account from the current organization, then
            /// try link again.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource where this Analytics account link will be created. Format:
            /// organizations/{org_id}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.AnalyticsAccountLink body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates the link between the Analytics account and the Google Marketing Platform organization. User
            /// needs to be an org user, and admin on the Analytics account to create the link. If the account is
            /// already linked to an organization, user needs to unlink the account from the current organization, then
            /// try link again.
            /// </summary>
            public class CreateRequest : GoogleMarketingPlatformAdminAPIBaseServiceRequest<Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.AnalyticsAccountLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.AnalyticsAccountLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource where this Analytics account link will be created. Format:
                /// organizations/{org_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.AnalyticsAccountLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/analyticsAccountLinks";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from the Google Marketing
            /// Platform organization. User needs to be an org user, and admin on the Analytics account in order to
            /// delete the link.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the Analytics account link to delete. Format:
            /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from the Google Marketing
            /// Platform organization. User needs to be an org user, and admin on the Analytics account in order to
            /// delete the link.
            /// </summary>
            public class DeleteRequest : GoogleMarketingPlatformAdminAPIBaseServiceRequest<Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the Analytics account link to delete. Format:
                /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^organizations/[^/]+/analyticsAccountLinks/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the Google Analytics accounts link to the specified Google Marketing Platform organization.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent organization, which owns this collection of Analytics account links. Format:
            /// organizations/{org_id}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the Google Analytics accounts link to the specified Google Marketing Platform organization.
            /// </summary>
            public class ListRequest : GoogleMarketingPlatformAdminAPIBaseServiceRequest<Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.ListAnalyticsAccountLinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent organization, which owns this collection of Analytics account links. Format:
                /// organizations/{org_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of Analytics account links to return in one call. The service may
                /// return fewer than this value. If unspecified, at most 50 Analytics account links will be returned.
                /// The maximum value is 1000; values above 1000 will be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous ListAnalyticsAccountLinks call. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListAnalyticsAccountLinks` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/analyticsAccountLinks";

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

            /// <summary>Updates the service level for an Analytics property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="analyticsAccountLink">
            /// Required. The parent AnalyticsAccountLink scope where this property is in. Format:
            /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
            /// </param>
            public virtual SetPropertyServiceLevelRequest SetPropertyServiceLevel(Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.SetPropertyServiceLevelRequest body, string analyticsAccountLink)
            {
                return new SetPropertyServiceLevelRequest(this.service, body, analyticsAccountLink);
            }

            /// <summary>Updates the service level for an Analytics property.</summary>
            public class SetPropertyServiceLevelRequest : GoogleMarketingPlatformAdminAPIBaseServiceRequest<Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.SetPropertyServiceLevelResponse>
            {
                /// <summary>Constructs a new SetPropertyServiceLevel request.</summary>
                public SetPropertyServiceLevelRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.SetPropertyServiceLevelRequest body, string analyticsAccountLink) : base(service)
                {
                    AnalyticsAccountLink = analyticsAccountLink;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent AnalyticsAccountLink scope where this property is in. Format:
                /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("analyticsAccountLink", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AnalyticsAccountLink { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.SetPropertyServiceLevelRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setPropertyServiceLevel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+analyticsAccountLink}:setPropertyServiceLevel";

                /// <summary>Initializes SetPropertyServiceLevel parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("analyticsAccountLink", new Google.Apis.Discovery.Parameter
                    {
                        Name = "analyticsAccountLink",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/analyticsAccountLinks/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data
{
    /// <summary>
    /// A resource message representing the link between a Google Analytics account and a Google Marketing Platform
    /// organization.
    /// </summary>
    public class AnalyticsAccountLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The resource name of the AnalyticsAdmin API account. The account ID will be used as the
        /// ID of this AnalyticsAccountLink resource, which will become the final component of the resource name.
        /// Format: analyticsadmin.googleapis.com/accounts/{account_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsAccount")]
        public virtual string AnalyticsAccount { get; set; }

        /// <summary>Output only. The human-readable name for the Analytics account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The verification state of the link between the Analytics account and the parent organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkVerificationState")]
        public virtual string LinkVerificationState { get; set; }

        /// <summary>
        /// Identifier. Resource name of this AnalyticsAccountLink. Note the resource ID is the same as the ID of the
        /// Analtyics account. Format: organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id} Example:
        /// "organizations/xyz/analyticsAccountLinks/1234"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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

    /// <summary>Response message for ListAnalyticsAccountLinks RPC.</summary>
    public class ListAnalyticsAccountLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Analytics account links in this organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsAccountLinks")]
        public virtual System.Collections.Generic.IList<AnalyticsAccountLink> AnalyticsAccountLinks { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SetPropertyServiceLevel RPC.</summary>
    public class SetPropertyServiceLevelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Analytics property to change the ServiceLevel setting. This field is the name of the Google
        /// Analytics Admin API property resource. Format: analyticsadmin.googleapis.com/properties/{property_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsProperty")]
        public virtual string AnalyticsProperty { get; set; }

        /// <summary>Required. The service level to set for this property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLevel")]
        public virtual string ServiceLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SetPropertyServiceLevel RPC.</summary>
    public class SetPropertyServiceLevelResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
