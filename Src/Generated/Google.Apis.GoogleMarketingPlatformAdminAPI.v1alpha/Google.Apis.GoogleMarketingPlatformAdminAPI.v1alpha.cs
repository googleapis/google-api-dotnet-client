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

        /// <summary>
        /// Returns a list of clients managed by the sales partner organization. User needs to be an
        /// OrgAdmin/BillingAdmin on the sales partner organization in order to view the end clients.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="organization">
        /// Required. The name of the sales partner organization. Format: organizations/{org_id}
        /// </param>
        public virtual FindSalesPartnerManagedClientsRequest FindSalesPartnerManagedClients(Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.FindSalesPartnerManagedClientsRequest body, string organization)
        {
            return new FindSalesPartnerManagedClientsRequest(this.service, body, organization);
        }

        /// <summary>
        /// Returns a list of clients managed by the sales partner organization. User needs to be an
        /// OrgAdmin/BillingAdmin on the sales partner organization in order to view the end clients.
        /// </summary>
        public class FindSalesPartnerManagedClientsRequest : GoogleMarketingPlatformAdminAPIBaseServiceRequest<Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.FindSalesPartnerManagedClientsResponse>
        {
            /// <summary>Constructs a new FindSalesPartnerManagedClients request.</summary>
            public FindSalesPartnerManagedClientsRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.FindSalesPartnerManagedClientsRequest body, string organization) : base(service)
            {
                Organization = organization;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the sales partner organization. Format: organizations/{org_id}</summary>
            [Google.Apis.Util.RequestParameterAttribute("organization", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Organization { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.FindSalesPartnerManagedClientsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "findSalesPartnerManagedClients";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+organization}:findSalesPartnerManagedClients";

            /// <summary>Initializes FindSalesPartnerManagedClients parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("organization", new Google.Apis.Discovery.Parameter
                {
                    Name = "organization",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>Lookup for a single organization.</summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve. Format: organizations/{org_id}
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Lookup for a single organization.</summary>
        public class GetRequest : GoogleMarketingPlatformAdminAPIBaseServiceRequest<Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.Organization>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the Organization to retrieve. Format: organizations/{org_id}</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+name}";

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
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>Returns a list of organizations that the user has access to.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of organizations that the user has access to.</summary>
        public class ListRequest : GoogleMarketingPlatformAdminAPIBaseServiceRequest<Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.ListOrganizationsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of organizations to return in one call. The service may return fewer than
            /// this value. If unspecified, at most 50 organizations will be returned. The maximum value is 1000; values
            /// above 1000 will be coerced to 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous ListOrganizations call. Provide this to retrieve the
            /// subsequent page. When paginating, all other parameters provided to `ListOrganizations` must match the
            /// call that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/organizations";

            /// <summary>Initializes List parameter list.</summary>
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
            }
        }

        /// <summary>
        /// Get the usage and billing data for properties within the organization for the specified month. Per direct
        /// client org, user needs to be OrgAdmin/BillingAdmin on the organization in order to view the billing and
        /// usage data. Per sales partner client org, user needs to be OrgAdmin/BillingAdmin on the sales partner org in
        /// order to view the billing and usage data, or OrgAdmin/BillingAdmin on the sales partner client org in order
        /// to view the usage data only.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="organization">
        /// Required. Specifies the organization whose property usage will be listed. Format: organizations/{org_id}
        /// </param>
        public virtual ReportPropertyUsageRequest ReportPropertyUsage(Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.ReportPropertyUsageRequest body, string organization)
        {
            return new ReportPropertyUsageRequest(this.service, body, organization);
        }

        /// <summary>
        /// Get the usage and billing data for properties within the organization for the specified month. Per direct
        /// client org, user needs to be OrgAdmin/BillingAdmin on the organization in order to view the billing and
        /// usage data. Per sales partner client org, user needs to be OrgAdmin/BillingAdmin on the sales partner org in
        /// order to view the billing and usage data, or OrgAdmin/BillingAdmin on the sales partner client org in order
        /// to view the usage data only.
        /// </summary>
        public class ReportPropertyUsageRequest : GoogleMarketingPlatformAdminAPIBaseServiceRequest<Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.ReportPropertyUsageResponse>
        {
            /// <summary>Constructs a new ReportPropertyUsage request.</summary>
            public ReportPropertyUsageRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.ReportPropertyUsageRequest body, string organization) : base(service)
            {
                Organization = organization;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Specifies the organization whose property usage will be listed. Format: organizations/{org_id}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("organization", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Organization { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleMarketingPlatformAdminAPI.v1alpha.Data.ReportPropertyUsageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reportPropertyUsage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+organization}:reportPropertyUsage";

            /// <summary>Initializes ReportPropertyUsage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("organization", new Google.Apis.Discovery.Parameter
                {
                    Name = "organization",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+$",
                });
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

    /// <summary>Contains the bill amount.</summary>
    public class BillInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount of the monthly base fee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseFee")]
        public virtual Money BaseFee { get; set; }

        /// <summary>The amount of the event fee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventFee")]
        public virtual Money EventFee { get; set; }

        /// <summary>The amount of the price protection credit, this is only available for eligible customers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceProtectionCredit")]
        public virtual Money PriceProtectionCredit { get; set; }

        /// <summary>The total amount of the bill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("total")]
        public virtual Money Total { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the client data.</summary>
    public class ClientData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end date of the contract between the sales org and the end client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>The end client that has/had contract with the requested sales org.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual Organization Organization { get; set; }

        /// <summary>The start date of the contract between the sales org and the end client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

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

    /// <summary>Request message for FindSalesPartnerManagedClients RPC.</summary>
    public class FindSalesPartnerManagedClientsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set, only active and just ended clients will be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isActive")]
        public virtual System.Nullable<bool> IsActive { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for FindSalesPartnerManagedClients RPC.</summary>
    public class FindSalesPartnerManagedClientsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The clients managed by the sales org.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientData")]
        public virtual System.Collections.Generic.IList<ClientData> ClientData { get; set; }

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

    /// <summary>Response message for ListOrganizations RPC.</summary>
    public class ListOrganizationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The Organization resource that the user has access to, which includes the org id and display name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizations")]
        public virtual System.Collections.Generic.IList<Organization> Organizations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class Money : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a Google Marketing Platform organization.</summary>
    public class Organization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable name for the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Identifier. The resource name of the GMP organization. Format: organizations/{org_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the count of events received by the property, along with metadata that influences the volume of
    /// `billable` events.
    /// </summary>
    public class PropertyUsage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the property's parent account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<long> AccountId { get; set; }

        /// <summary>The number of events for which the property is billed in the requested month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billableEventCount")]
        public virtual System.Nullable<long> BillableEventCount { get; set; }

        /// <summary>The display name of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The name of the Google Analytics Admin API property resource. Format:
        /// analyticsadmin.googleapis.com/properties/{property_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>The subtype of the analytics property. This affects the billable event count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyType")]
        public virtual string PropertyType { get; set; }

        /// <summary>The service level of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLevel")]
        public virtual string ServiceLevel { get; set; }

        /// <summary>Total event count that the property received during the requested month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalEventCount")]
        public virtual System.Nullable<long> TotalEventCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ReportPropertyUsage RPC.</summary>
    public class ReportPropertyUsageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The target month to list property usages. Format: YYYY-MM. For example, "2025-05"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual string Month { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ReportPropertyUsage RPC.</summary>
    public class ReportPropertyUsageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Bill amount in the specified organization and month. Will be empty if user only has access to usage data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billInfo")]
        public virtual BillInfo BillInfo { get; set; }

        /// <summary>Usage data for all properties in the specified organization and month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyUsages")]
        public virtual System.Collections.Generic.IList<PropertyUsage> PropertyUsages { get; set; }

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
